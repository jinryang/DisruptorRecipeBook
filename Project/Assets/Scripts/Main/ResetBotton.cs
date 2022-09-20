using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBotton : MonoBehaviour
{
    public GameObject popUp;

    public void Reset()
    {
        Data.Instance.InitData();
        popUp.SetActive(true);
    }
}
