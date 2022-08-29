using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinkleTimeManager : MonoBehaviour
{
    public float time; //SprinkleTime
    public bool IsEnded = false; //Express the Sprinkle is Ended-this point
    public bool IsClick = false; //Express Player is clicking
    private bool IsOnPlace = false;
    [SerializeField] SprinkleManager sprinkleManager;
    void Start()
    {
        
    }
    private void OnMouseEnter()
    {
        IsOnPlace = true;
    }

    private void OnMouseExit()
    {
        IsOnPlace = false;
        sprinkleManager.InteractPos--;
        IsClick = false;
    }
    private void OnMouseUp()
    {
        sprinkleManager.InteractPos--;
        IsClick = false;
    }
    void Update()
    {
        if(sprinkleManager.InteractPos < 0)
        {
            sprinkleManager.InteractPos = 0;
        }
        if (IsOnPlace && Input.GetMouseButtonDown(0))
        {
            sprinkleManager.InteractPos++;
            IsClick = true;
        }

        if (IsClick == true && sprinkleManager.InteractPos == 1)
        {
            time -= Time.deltaTime;
        }

        if (time <= 0)
        {
            IsEnded = true;
        }

    }

}
