using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookTimer : MonoBehaviour
{
    [SerializeField] private float timer;
    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        text.text = Mathf.Round(timer).ToString() + ":00";
    }
    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer >= 0) text.text = Mathf.Round(timer).ToString("00") + ":" + (Mathf.Round(timer * 100) % 100).ToString("00");
        else
        {
            text.text = "00:00";
            //게임 끝내기
        }
    }
}
