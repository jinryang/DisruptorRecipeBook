using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpDropPoint : MonoBehaviour
{
    public DropPoint dropPoint;
    public int UPDP = 0;
    void Start()
    {
        dropPoint = FindObjectOfType<DropPoint>();
        if (transform.position.x >= -(1+SkillManagement.Instance.ExcellentBalance()) && transform.position.x <= (1 + SkillManagement.Instance.ExcellentBalance()))
        {
            UPDP = (int)(50*SkillManagement.Instance.CookingMaster()*SkillManagement.Instance.Perfectionist());
            MinigameManagement.Instance.PlusScore(UPDP);
            dropPoint.DP += UPDP;
        }
        else if(transform.position.x >= -(3 + SkillManagement.Instance.ExcellentBalance()) && transform.position.x <= (3 + SkillManagement.Instance.ExcellentBalance()))
        {
            UPDP = (int)(30 * SkillManagement.Instance.CookingMaster());
            MinigameManagement.Instance.PlusScore(UPDP);
            dropPoint.DP += UPDP;
        }
        else if (transform.position.x >= -6 && transform.position.x <= 6)
        {
            UPDP = (int)(20 * SkillManagement.Instance.CookingMaster());
            MinigameManagement.Instance.PlusScore(UPDP);
            dropPoint.DP += UPDP;
        }
        else if (transform.position.x >= -10 && transform.position.x <= 10)
        {
            UPDP = (int)(1 * SkillManagement.Instance.CookingMaster());
            MinigameManagement.Instance.PlusScore(UPDP);
            dropPoint.DP += UPDP;
        }
    }
}
