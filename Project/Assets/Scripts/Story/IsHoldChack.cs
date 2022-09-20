using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsHoldChack : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;

    void Awake()
    {
        int count = 0;
        for (int i = 1; i < 9; i++)
        {
            if (!RecipeDatas.Instance.Recipes[i].isHold)
            {
                count++;
                buttons[i + 1].GetComponent<OpenStory>().isHold = false;
            }
        }
        if (count != 0)
        {
            buttons[10].GetComponent<OpenStory>().isHold = false;
        }
    }
}
