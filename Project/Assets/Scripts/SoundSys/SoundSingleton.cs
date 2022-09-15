using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSingleton : MonoBehaviour
{
    [SerializeField] AudioClip[] BGM;
    [SerializeField] AudioClip[] EF;
    [SerializeField] AudioSource audio;
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
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void SetSound(bool IsBGM, int numof)
    {
        if (IsBGM == true)
        {
            audio.clip = BGM[numof];
        }
        else
        {
            audio.clip = EF[numof];
        }
    }
    public void PlaySound()
    {
        audio.Play();
    }

    public void Stop()
    {
        audio.Stop();
    }

    public void FadeInBGM()
    {
        StopAllCoroutines();
        StartCoroutine(FadeIn());
    }

    public void FadeOutBGM()
    {
        StopAllCoroutines();
        StartCoroutine(FadeOut());
    }
    IEnumerator FadeIn()
    {
        for (float i = 0f; i <= 1f; i += fadeRange)
        {
            audio.volume = i;
            yield return wait;
        }
    }
    IEnumerator FadeOut()
    {
        for (float i = 1.0f; i >= 0f; i -= fadeRange)
        {
            audio.volume = i;
            yield return wait;
        }
    }
}
