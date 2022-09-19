using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSingleton : MonoBehaviour
{
    [SerializeField] AudioClip[] BGM;
    [SerializeField] AudioClip[] EF;
    [SerializeField] AudioSource[] audio;
    public float fadeRange;

    private WaitForSeconds wait = new WaitForSeconds(0.01f);

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

    private void Start()
    {
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audio[1].clip = EF[0];
            audio[1].Play();
        }
    }

    public void SetSound(bool IsBGM, int numof)
    {
        if (IsBGM == true)
        {
            audio[0].clip = BGM[numof];
        }
        else
        {
            audio[1].clip = EF[numof];
        }
    }
    public void PlaySound(bool IsBGM)
    {
        if (IsBGM)
        {
            audio[0].Play();
        }
        else
        {
            audio[1].Play();
        }
    }

    public void Stop(bool IsBGM)
    {
        if(IsBGM)
        {
            audio[0].Stop();
        }
        else
        {
            audio[1].Stop();
        }
        
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
