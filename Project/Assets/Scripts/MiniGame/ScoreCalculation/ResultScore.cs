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
        int point;

        switch (length)
        {
            case 1:
                t1.text = MinigameManagement.Instance.points[0].ToString();
                point = MinigameManagement.Instance.points[0];
                result.text = point.ToString();
                break;
            case 2:
                t1.text = MinigameManagement.Instance.points[0].ToString();
                t2.text = MinigameManagement.Instance.points[1].ToString();
                point = (MinigameManagement.Instance.points[0] + MinigameManagement.Instance.points[1]);
                result.text = point.ToString();
                break;
            case 3:
                t1.text = MinigameManagement.Instance.points[0].ToString();
                t2.text = MinigameManagement.Instance.points[1].ToString();
                t3.text = MinigameManagement.Instance.points[2].ToString();
                point = (MinigameManagement.Instance.points[0] + MinigameManagement.Instance.points[1] + MinigameManagement.Instance.points[2]);
                result.text = point.ToString();
                break;
            default:
                point = 0;
                break;
        }

        PlayerDataManagement.Instance.PlusPoint(point);
    }
}
