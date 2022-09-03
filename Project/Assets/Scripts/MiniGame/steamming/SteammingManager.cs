using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteammingManager : MonoBehaviour
{
    [SerializeField] private float time = 10;//타이머로 교체
    private float tempTime;
    [SerializeField] private int[] decision;
    private bool IsStarted;
    private int score;
    private int buttonNum = 0;

    private void Start()
    {
        tempTime = time;
        time = 0;
    }

    private void Update()
    {
        if (IsStarted)
        {
            time += Time.deltaTime;//타이머로 교체
        }
    }
    public void ButtonFunction()
    {
        if (buttonNum == 0)
        {
            Debug.Log("testCase1 : Buttonfunctoin is first started");
            IsStarted = true;
            buttonNum++;
        }
        else if(buttonNum == 1)
        {

            IsStarted = false;
            StartCoroutine(Judge());
        }

    }

    

    IEnumerator Judge()
    {
        if(tempTime - time > 0)
        {
            score = decision[6];
        }
        else if(tempTime - time < 0.8f)
        {
            Debug.Log("1st!!");
            score = decision[4];
        }
        else if(tempTime - time < 1.2f)
        {
            Debug.Log("2nd!!");
            score = decision[3];
        }
        else if (tempTime - time < 1.5f)
        {
            Debug.Log("3rd!");
            score = decision[2];
        }
        else if (tempTime - time < 2f)
        {
            Debug.Log("4th:(");
            score = decision[1];
        }
        else if (tempTime - time < 2.5f)
        {
            Debug.Log("5th?? :M");
            score = decision[0];
        }
        yield return null;
    }

    public int GetScore() { return score; }
}