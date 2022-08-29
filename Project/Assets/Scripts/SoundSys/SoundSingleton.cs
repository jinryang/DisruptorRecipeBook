using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSingleton : MonoBehaviour
{
    [SerializeField] AudioClip[] BGM;
    [SerializeField] AudioClip[] EF;
    AudioSource audio;
    public float fadeRange;

    private WaitForSeconds wait = new WaitForSeconds(0.01f);    

    public SoundSingleton soundSingleton = null;
    private void Awake()
    {
        if(soundSingleton == null)
        {
            soundSingleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(soundSingleton != this)
        {
            Destroy(this.gameObject);
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
            audio.clip = BGM[numof - 1];
        }
        else
        {
            audio.clip = EF[numof - 1];
        }
    }
    public void PlaySound(bool IsBGM, int numof)
    {
        audio.Play();
    }

    public void stop()
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
