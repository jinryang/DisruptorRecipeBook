using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreeBoil : MonoBehaviour
{
    private float degree = 0;

    void FixedUpdate()
    {
        if (GetComponent<ObjectDragBoil>().onAble && !(GetComponent<ObjectDragBoil>().isMoving))
        {
            degree += Time.deltaTime;
            Debug.Log(degree);
        }
    }

    public int Point()
    {
        int point;
        if (degree < 3) { point = 0; }
        else if (degree < 6) { point = 30; }
        else if (degree < 9) { point = 50; }
        else if (degree < 12) { point = 70; }
        else { point = 10; }
        return point;
    }
}
