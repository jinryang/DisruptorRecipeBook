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
    public Image temg;
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
                    AddTemPoint();
                    po.AddPoint(tempoint);
                    temb.SetActive(true);
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
        if (tem.nowtem <= 165 && tem.nowtem >= 155)
            temg.color = Color.green;
        else if (tem.nowtem <= 170 && tem.nowtem >= 140)
            temg.color = Color.yellow;
        else if (tem.nowtem <= 180 && tem.nowtem >= 120)
            temg.color = Color.red + Color.yellow;
        else if (tem.nowtem <= 190 && tem.nowtem > 100)
            temg.color = Color.red;
        else if (tem.nowtem <= 200 && tem.nowtem > 100)
            temg.color = Color.black;
        else if (tem.nowtem <= 100)
            temg.color = Color.blue;
    }
    public void OutButton()
    {
        stop = true;
        temb.SetActive(true);
    }
    public void TimeReset()
    {
        time = 20;
        temb.SetActive(false);
    }
    public void AddTemPoint()
    {
        if (tem.nowtem <= 165 && tem.nowtem >= 155)
            tempoint = 100;
        else if (tem.nowtem <= 170 && tem.nowtem >= 140)
            tempoint = 70;
        else if(tem.nowtem <= 180 && tem.nowtem >= 120)
            tempoint = 50;
        else if(tem.nowtem <= 190 && tem.nowtem > 100)
            tempoint = 30;
        else if(tem.nowtem <= 200)
            tempoint = 10;
        else if (tem.nowtem <= 100)
            tempoint = 10;
    }
    public void AddTimePoint()
    {
        if (time >= 10)
            timepoint = 100;
    }
}