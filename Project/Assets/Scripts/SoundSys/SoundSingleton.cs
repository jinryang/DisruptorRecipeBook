using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SoundSingleton : MonoBehaviour
{
    enum GameBGM
    {
        TheBlueSky,
        Openning,
        Cafeteria,
    }

    [SerializeField] AudioClip[] BGM;
    [SerializeField] AudioClip[] EF;
    [SerializeField] AudioSource[] audio;
    [SerializeField] AudioSource click;
    private Slider soundSlider;
    public float fadeRange;
    bool FIndTarget = false;

    private WaitForSeconds wait = new WaitForSeconds(0.01f);

    #region Singleton
    private static SoundSingleton instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }
    public static SoundSingleton Instance
    {
        get
        {
            if (null == instance)
            {
                instance = null;
            }
            return instance;
        }
    }
    #endregion

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click.Play();
        }
        if (GameObject.FindWithTag("SoundSlider") && FIndTarget == false)
        {
            soundSlider = GameObject.FindWithTag("SoundSlider").GetComponent<Slider>();
            FIndTarget = true;
        }
        if (FIndTarget)
        {
            click.volume = soundSlider.value;
            for (int i = 0; i < audio.Length; ++i)
            {
                audio[i].volume = soundSlider.value;
            }
        }

    }

    public void SetClickSounds(AudioClip clickSound)
    {
        click.clip = clickSound;
    }

    public void StartBGM(int index)
    {
        if (audio[0].clip != BGM[index])
        {
            audio[0].clip = BGM[index];
            audio[0].Play();
        }
    }
    public void StartEF(int index, int numof)
    {
        audio[numof].clip = EF[index];
        audio[numof].Play();
    }

    public void StopBGM()
    {
        audio[0].Stop();
    }

    public void StopEF(int numof)
    {
        audio[numof].Stop();
    }

    /*public void FadeInBGM()
    {
        StopAllCoroutines();
        StartCoroutine(FadeIn());
    }

    public void FadeOutBGM()
    {
        StopAllCoroutines();
        StartCoroutine(FadeOut());
    }*/

    /*IEnumerator FadeIn()
    {
        for (float i = 0f; i <= 1f; i += fadeRange)
        {
            audio[0].volume = i;
            yield return wait;
        }
    }
    IEnumerator FadeOut()
    {
        for (float i = 1.0f; i >= 0f; i -= fadeRange)
        {
            audio[0].volume = i;
            yield return wait;
        }
    }*/
}
