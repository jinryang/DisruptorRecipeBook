using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropPoint : MonoBehaviour
{
    public int DP = 0;
    public Text DPtext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DPtext.text = "Æ÷ÀÎÆ® : " + DP;
    }
}
