using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private int point;
    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    public void AddPoint(int add)
    {
        point += add;
    }
}
