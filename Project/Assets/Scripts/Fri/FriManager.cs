using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriManager : MonoBehaviour
{
    public int numberOfFlip;
    private Vector3 BeginPos;
    private Vector3 EndPos;
    private int Friway;
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
    }


    IEnumerator judgeDragway(int Friway)
    {
        
        yield return null;
    }

    IEnumerator ChooseFriway()
    {
        Friway = Random.Range(0, 4) + 1;
        yield return null;
    }
}
