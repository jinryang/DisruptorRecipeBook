using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPoint : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Text>().text = PlayerDataManagement.Instance.Point.ToString();
    }
}
