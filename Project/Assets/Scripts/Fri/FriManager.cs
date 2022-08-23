using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriManager : MonoBehaviour
{
    public int numberOfFlip;
    private Vector3 BeginPos;
    private Vector3 EndPos;
    private int Friway;
    public int responsiveness;
    public float score;
    private bool xIsPerfect = false;
    private bool yIsPerfect = false;
    private bool IsClick = false;
    int time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChooseFriway());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(0))
        {
            BeginPos = Input.mousePosition;
        }
        if(Input.GetKeyUp(0))
        {
            EndPos = Input.mousePosition;
        }
        if(xIsPerfect == true && yIsPerfect == true)
        {
            //addscore
            if (numberOfFlip == 0)
            {
                //EndOfFlip
            }
            else numberOfFlip--;
        }
    }


    IEnumerator judgeDragway(int Friway)
    {
        if(Friway == 1)//왼쪽 위 x-, y+
        {
            if(BeginPos.x - EndPos.x <= responsiveness)
            {
                xIsPerfect = true;
            }
            if(EndPos.y - BeginPos.y <= responsiveness / 1.3f)//윗쪽 판정은 좋게
            {
                yIsPerfect = true;
            }
        }
        else if(Friway == 2)//오른쪽 위 x+, y+
        {
            if(EndPos.x - BeginPos.x <= responsiveness)
            {
                xIsPerfect = true;
            }
            if(EndPos.y - BeginPos.y <= responsiveness / 1.3f)
            {
                yIsPerfect = true;
            }
        }
        else if(Friway == 3)//왼쪽 아래 x-, y-
        {
            if (BeginPos.x - EndPos.x <= responsiveness)
            {
                xIsPerfect = true;
            }
            if (BeginPos.y - EndPos.y <= responsiveness / 1.3f)
            {
                yIsPerfect = true;
            }
        }
        else//오른쪽 아래 x+, y-
        {
            if (EndPos.x - BeginPos.x <= responsiveness)
            {
                xIsPerfect = true;
            }
            if (BeginPos.y - EndPos.y <= responsiveness / 1.3f)
            {
                yIsPerfect = true;
            }
        }


        yield return null;
    }

    IEnumerator ChooseFriway()
    {
        Friway = Random.Range(0, 4) + 1;
        yield return null;
    }
}
