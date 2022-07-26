using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySkillChack : MonoBehaviour
{
    [SerializeField] private GameObject[] items;

    private void Awake()
    {
        for (int i = 0; i < 12; i++)
        {
            if (SkillManagement.Instance.Skills[i].isHold)
            {
                Destroy(items[i]);
            }
        }
    }
}
