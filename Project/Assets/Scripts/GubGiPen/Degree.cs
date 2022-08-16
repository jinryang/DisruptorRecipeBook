using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degree : MonoBehaviour
{
    private float degree = 0;

    void FixedUpdate()
    {
        if (GetComponent<ObjectDrag>().onAble)
        {
            degree += Time.deltaTime;
            Debug.Log(degree);
        }
    }
}
