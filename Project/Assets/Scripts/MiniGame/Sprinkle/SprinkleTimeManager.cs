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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Mouse"))
        {
            time -= Time.deltaTime;
        }
    }

    void Update()
    {
       
        if (time <= 0)
        {
            IsEnded = true;
        }

    }

}
