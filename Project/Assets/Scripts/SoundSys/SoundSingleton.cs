using System.Collections;
using System.Collections.Generic;
using UnityEngine;



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
    public float fadeRange;

    private WaitForSeconds wait = new WaitForSeconds(0.01f);

    #region Singleton
    private static SoundSingleton instance = null;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
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
        if(Input.GetMouseButtonDown(0))
        {
            click.Play();
        }
    }//bgm = audio[0]
    //ef = audio[1]

    public void StartBGM(int index)
    {
        audio[0].clip = BGM[index];
        audio[0].Play();
    }
    public void StartEF(int index)
    {
        audio[1].clip = EF[index];
        audio[1].Play();
    }

    public void StopBGM()
    {
        audio[0].Stop();
    }

    public void StopEF()
    {
        audio[1].Stop();
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
