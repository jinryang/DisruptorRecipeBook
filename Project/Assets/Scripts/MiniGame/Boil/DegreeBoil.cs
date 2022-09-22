using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreeBoil : MonoBehaviour
{
    private float degree = 0;
    public Sprite[] sp;
    int point;
    void FixedUpdate()
    {
        if (degree < 3)
        {
            GetComponent<SpriteRenderer>().sprite = sp[0];
            point = 0;
        }
        else if (degree < 6)
        {
            GetComponent<SpriteRenderer>().sprite = sp[1];
            point = 30;
        }
        else if (degree < 9)
        {
            GetComponent<SpriteRenderer>().sprite = sp[2];
            point = 50;
        }
        else if (degree < 12)
        {
            GetComponent<SpriteRenderer>().sprite = sp[3];
            point = 70;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = sp[4];
            point = 10;
        }

        if (GetComponent<ObjectDragBoil>().onAble && !(GetComponent<ObjectDragBoil>().isMoving))
        {
            degree += Time.deltaTime;
        }
    }

    public int Point()
    {
        return point;
    }
}
