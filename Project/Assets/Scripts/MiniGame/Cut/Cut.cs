using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cut : MonoBehaviour
{
    public CutTimer cuttimer;
    public Slider CutSlider;
    public int MaxCut = 100;
    public float NowCut = 0;
    public float CutSpeed = 2;
    public GameObject TimeStop;
    public GameObject cover;
    public Text CutText;
    public int CutPoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        TimeStop.SetActive(true);
        CutPoint = 0;
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
            CutPoint = 100;
        }
        else if (NowCut >= 70 && cuttimer.cuttimepoint == true)
        {
            TimeStop.SetActive(false);
            cover.SetActive(true);
            CutPoint = 70;
        }
        else if (NowCut >= 50 && cuttimer.cuttimepoint == true)
        {
            TimeStop.SetActive(false);
            cover.SetActive(true);
            CutPoint = 50;
        }
        else if (NowCut >= 30 && cuttimer.cuttimepoint == true)
        {
            TimeStop.SetActive(false);
            cover.SetActive(true);
            CutPoint = 30;
        }
        else if (NowCut < 30 && cuttimer.cuttimepoint == true)
        {
            TimeStop.SetActive(false);
            cover.SetActive(true);
            CutPoint = 10;
        }
        CutText.text = "point : " + CutPoint;
    }
    public void CutButton()
    {
        NowCut += CutSpeed;
    }
}
