using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriManager : MonoBehaviour
{
    public int FlipNum;
    private Vector3 BeginPos;
    private Vector3 EndPos;
    private int Friway;
    public float responsiveness;
    public float score;
    private bool xIsPerfect = false;
    private bool yIsPerfect = false;
    private bool IsClick = false;
    int time;
    // Start is called before the first frame update
    void Start()
    {
        ChooseFriway();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("click");
            BeginPos = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("up");
            EndPos = Input.mousePosition;
            judgeDragway(Friway);
        }
        if(xIsPerfect == true && yIsPerfect == true)
        {
            //addscore
            if (FlipNum <= 0)
            {
                //EndOfFlip
                Debug.Log("FlipIsEnded");
            }
            else
            { 
                FlipNum--;
                xIsPerfect = false;
                yIsPerfect = false;
                ChooseFriway();
            }
        }
    }

    public int GetFriWay() { return Friway; }

    void ChooseFriway()
    {
        Friway = Random.Range(0, 4) + 1;
        Debug.Log(Friway);
    }

    void judgeDragway(int Friway)
    {
        if (Friway == 1)//up, left x-, y+
        {
            if (EndPos.x - BeginPos.x <= -responsiveness)
            {
                xIsPerfect = true;
            }
            if (EndPos.y - BeginPos.y >= responsiveness / 1.3f)
            {
                yIsPerfect = true;
            }
        }
        else if (Friway == 2)//up, right x+, y+
        {
            if (EndPos.x - BeginPos.x >= responsiveness)
            {
                xIsPerfect = true;
            }
            if (EndPos.y - BeginPos.y >= responsiveness / 1.3f)
            {
                yIsPerfect = true;
            }
        }
        else if (Friway == 3)//down, left x-, y-
        {
            if (EndPos.x - BeginPos.x <= -responsiveness)
            {
                xIsPerfect = true;
            }
            if (EndPos.y - BeginPos.y <= responsiveness / 1.3f)
            {
                yIsPerfect = true;
            }
        }
        else//down, right x+, y-
        {
            if (EndPos.x - BeginPos.x >= responsiveness)
            {
                xIsPerfect = true;
            }
            if (EndPos.y - BeginPos.y <= responsiveness / 1.3f)
            {
                yIsPerfect = true;
            }
        }
    }

}
