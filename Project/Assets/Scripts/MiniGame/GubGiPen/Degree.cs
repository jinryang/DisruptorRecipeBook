using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degree : MonoBehaviour
{
    private float degree = 0;

    void FixedUpdate()
    {
        if (GetComponent<ObjectDrag>().onAble && !(GetComponent<ObjectDrag>().isMoving))
        {
            degree += Time.deltaTime;
            Debug.Log(degree);
        }
    }

    public int Point()
    {
        int point;
        if (degree < 2) { point = 10; }
        else if (degree < 3) { point = 30; }
        else if (degree < 4) { point = 100; }
        else if (degree < 5) { point = 50; }
        else { point = 10; }
        return point;
    }
}
