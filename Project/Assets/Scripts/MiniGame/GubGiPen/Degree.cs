using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degree : MonoBehaviour
{
    private float degree = 0;
    public Sprite[] sp;
    int point;

    void FixedUpdate()
    {
        if (GetComponent<ObjectDrag>().onAble && !(GetComponent<ObjectDrag>().isMoving))
        {
            degree += Time.deltaTime;
        }
        if (degree < 2)
        {
            GetComponent<SpriteRenderer>().sprite = sp[0];
            point = (int)(10 * SkillManagement.Instance.TimeAttackPoint());
        }
        else if (degree < 3)
        {
            GetComponent<SpriteRenderer>().sprite = sp[1];
            point = (int)(30 * SkillManagement.Instance.TimeAttackPoint());
        }
        else if (degree < 4)
        {
            GetComponent<SpriteRenderer>().sprite = sp[2];
            point = (int)(100 * SkillManagement.Instance.TimeAttackPoint());
        }
        else if (degree < 6)
        {
            GetComponent<SpriteRenderer>().sprite = sp[3];
            point = (int)(50 * SkillManagement.Instance.TimeAttackPoint());
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = sp[4];
            point = (int)(10 * SkillManagement.Instance.TimeAttackPoint());
        }
    }

    public int Point()
    {
        return point;
    }
}
