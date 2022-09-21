using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyChack : MonoBehaviour
{
    [SerializeField] private GameObject[] items;

    private void Awake()
    {
        for (int i = 1; i < 9; i++)
        {
            if (RecipeDatas.Instance.Recipes[i].isHold)
            {
                Destroy(items[i - 1]);
            }
        }
    }
}
