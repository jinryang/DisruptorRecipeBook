using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    int a = 0;
    public bool reset;
    public bool stop;
    public float time = 20;
    public GameObject tembutton;
    public GameObject temb;
    public TextMeshProUGUI TimeText;
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
                    Invoke("TimeReset", 3.0f);
                    a++;
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
}