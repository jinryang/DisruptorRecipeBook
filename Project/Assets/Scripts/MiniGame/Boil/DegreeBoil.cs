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
            point = (int)(30 * SkillManagement.Instance.TimeAttackPoint());
        }
        else if (degree < 9)
        {
            GetComponent<SpriteRenderer>().sprite = sp[2];
            point = (int)(50 * SkillManagement.Instance.TimeAttackPoint());
        }
        else if (degree < 12)
        {
            GetComponent<SpriteRenderer>().sprite = sp[3];
            point = (int)(70f * SkillManagement.Instance.Perfectionist() * SkillManagement.Instance.TimeAttackPoint());
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(0.5f,0.5f,0.5f,1);
            point = (int)(10 * SkillManagement.Instance.TimeAttackPoint());
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
