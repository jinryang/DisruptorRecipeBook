using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveSkillChack : MonoBehaviour
{
    [SerializeField] private GameObject[] items;

    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            if (!SkillManagement.Instance.Skills[i].isHold)
            {
                Destroy(items[i]);
            }
        }
    }
}
