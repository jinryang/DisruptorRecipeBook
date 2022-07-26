using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreeBoil : MonoBehaviour
{
    private float degree = 0;
    public Sprite[] sp;
    int point;
    GameObject Timer;
    float time;
    private void Start()
    {
        Timer = GameObject.Find("Canvas").transform.GetChild(0).gameObject;
        time = Timer.GetComponent<CookTimer>().timer;
    }
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
            point = (int)(30 * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.LastSpurt(time) * SkillManagement.Instance.TimeAttackPoint());
        }
        else if (degree < 9)
        {
            GetComponent<SpriteRenderer>().sprite = sp[2];
            point = (int)(50 * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.LastSpurt(time) * SkillManagement.Instance.TimeAttackPoint());
        }
        else if (degree < 12)
        {
            GetComponent<SpriteRenderer>().sprite = sp[3];
            point = (int)(70f * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.LastSpurt(time) * SkillManagement.Instance.Perfectionist() * SkillManagement.Instance.TimeAttackPoint());
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, 1);
            point = (int)(10 * SkillManagement.Instance.CookingGodBlessing(10, 50) * SkillManagement.Instance.NotEpicurean() * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.LastSpurt(time) * SkillManagement.Instance.TimeAttackPoint());
        }

        if (GetComponent<ObjectDragBoil>().onAble && !(GetComponent<ObjectDragBoil>().isMoving))
        {
            degree += Time.deltaTime;
        }
    }

    public int Point()
    {
        if (degree < 3) { point = 0; }
        else if (degree < 6) { point = 30; }
        else if (degree < 9) { point = 50; }
        else if (degree < 12) { point = 70; }
        else { point = 10; }
        return point;
    }
}
