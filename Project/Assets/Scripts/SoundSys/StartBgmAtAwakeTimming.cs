using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBgmAtAwakeTimming : MonoBehaviour
{
    public bool IsBGM = true;
    public int numof = 0;
    void Start()
    {
        SoundSingleton.Instance.SetSound(IsBGM, numof);
        SoundSingleton.Instance.PlaySound();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
