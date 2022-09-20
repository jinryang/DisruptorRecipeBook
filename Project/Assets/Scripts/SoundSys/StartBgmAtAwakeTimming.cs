using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBgmAtAwakeTimming : MonoBehaviour
{
    public int numof = 0;
    void Start()
    {
        SoundSingleton.Instance.StartBGM(numof);
    }
}
