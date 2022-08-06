using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cut : MonoBehaviour
{
    public Slider CutSlider;
    public int MaxCut = 100;
    public float NowCut = 0;
    public float CutSpeed = 2;
    public GameObject TimeStop;
    public GameObject cover;
    // Start is called before the first frame update
    void Start()
    {
        TimeStop.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CutSlider.value = NowCut;
        if(NowCut >= 100)
        {
            NowCut = 100;
            TimeStop.SetActive(false);
            cover.SetActive(true);
        }
    }
    public void CutButton()
    {
        NowCut += CutSpeed;
    }
}
