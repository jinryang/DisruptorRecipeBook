using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CutTimer : MonoBehaviour
{
    public float time = 10;
    public TextMeshProUGUI TimeText;
    public GameObject cover;
    public bool cut;
    // Start is called before the first frame update
    void Start()
    {
        time = 10;
        cover.SetActive(false);
        cut = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (time > 0)
            time -= Time.deltaTime;
        else
        {
            time = 0;
            cover.SetActive(true);
            cut = false;
        }
        TimeText.text = string.Format("{0:N2}", time);
    }
}