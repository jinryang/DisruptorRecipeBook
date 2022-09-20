using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    [SerializeField] private string Name;
    [SerializeField] private string info;

    public Text nametext;
    public Text infotext;
    public void Click()
    {
        nametext.text = Name;
        infotext.text = info;
    }
}
