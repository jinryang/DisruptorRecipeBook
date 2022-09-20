using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPoint : MonoBehaviour
{
    public int NowPoint = 0;
    public Text nowpointtext;
    // Start is called before the first frame update
    void Start()
    {
        NowPoint = PlayerDataManagement.Instance.Point;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        nowpointtext.text = "Æ÷ÀÎÆ® : " + NowPoint;
    }
}
