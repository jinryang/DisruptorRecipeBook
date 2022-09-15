using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    [SerializeField] private Text t1;
    [SerializeField] private Text t2;
    [SerializeField] private Text t3;
    [SerializeField] private Text result;
    private int length = 0;

    void Start()
    {
        length = MinigameManagement.Instance.points.Length;

        switch (length)
        {
            case 1:
                t1.text = MinigameManagement.Instance.points[0].ToString();
                result.text = MinigameManagement.Instance.points[0].ToString();
                break;
            case 2:
                t1.text = MinigameManagement.Instance.points[0].ToString();
                t2.text = MinigameManagement.Instance.points[1].ToString();
                result.text = (MinigameManagement.Instance.points[0] + MinigameManagement.Instance.points[1]).ToString();
                break;
            case 3:
                t1.text = MinigameManagement.Instance.points[0].ToString();
                t2.text = MinigameManagement.Instance.points[1].ToString();
                t3.text = MinigameManagement.Instance.points[2].ToString();
                result.text = (MinigameManagement.Instance.points[0] + MinigameManagement.Instance.points[1] + MinigameManagement.Instance.points[2]).ToString();
                break;
        }
    }
}
