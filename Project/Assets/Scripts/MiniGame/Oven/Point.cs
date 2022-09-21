using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Point : MonoBehaviour
{
    private int point;
    public Text pointtext;
    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    public void AddPoint(int add)
    {
        point = add;
    }
    void FixedUpdate()
    {
        pointtext.text = "POINT : " + point;
        pointtext.color = Color.red;
    }
}
