using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temperature : MonoBehaviour
{
    public Slider TemperatureSlider;
    public int Maxtem = 200;
    public int Mintem = 30;
    public float nowtem;
    public float DectemSpeed = 0.3f;
    private bool isClick;

    public void ButtonDown()
    {
        isClick = true;
    }
    public void ButtonUp()
    {
        isClick = false;
    }
    void Start()
    {
        nowtem = Mintem;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TemperatureSlider.value = nowtem;
        if (isClick == true)
        {
            nowtem += DectemSpeed;

            if (nowtem >= Maxtem)
                nowtem = Maxtem;
        }
        else
        {
            nowtem -= DectemSpeed - 0.1f;

            if (nowtem <= Mintem)
                nowtem = Mintem;
        }

    }
}
