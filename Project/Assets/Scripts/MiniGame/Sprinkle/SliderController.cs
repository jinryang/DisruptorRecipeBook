using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] Slider[] slider;
    [SerializeField] SprinkleTimeManager[] sprinkle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < slider.Length; ++i)
        {
            slider[i].value = sprinkle[i].time / 2;
        }
    }
}
