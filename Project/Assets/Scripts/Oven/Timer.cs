using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Point po;
    public Temperature tem;

    int a = 0;
    public bool reset;
    public bool stop;
    public float time = 20;
    public GameObject tembutton;
    public GameObject temb;
    public TextMeshProUGUI TimeText;

    public int tempoint;
    public int timepoint;
    // Start is called before the first frame update
    void Start()
    {
        reset = false;
        stop = false;
        time = 20;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (stop == false)
        {
            if (time > 0)
                time -= Time.deltaTime;
            else
            {
                time = 0;
                tembutton.SetActive(false);
                if (a == 0)
                {
                    po.AddPoint(tempoint);
                    Invoke("TimeReset", 3.0f);
                    a++;
                }
                if (a == 1)
                {
                    po.AddPoint(timepoint);
                }
            }
        }
        TimeText.text = string.Format("{0:N2}", time);
    }
    public void OutButton()
    {
        stop = true;
    }
    public void TimeReset()
    {
        time = 20;
        temb.SetActive(false);
    }
    public void AddTemPoint()
    {
        if (tem.nowtem >= 160)
            tempoint = 100;
    }
    public void AddTimePoint()
    {
        if (time >= 10)
            timepoint = 100;
    }
}