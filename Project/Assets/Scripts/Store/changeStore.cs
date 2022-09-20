using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeStore : MonoBehaviour
{
    public GameObject cover1;
    public GameObject cover2;

    public GameObject ScrollView1;
    public GameObject ScrollView2;

    public Text name;
    public Text info;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Click()
    {
        name.text = "";
        info.text = "";
        cover1.SetActive(false);
        cover2.SetActive(true);
        ScrollView1.SetActive(false);
        ScrollView2.SetActive(true);
    }
}
