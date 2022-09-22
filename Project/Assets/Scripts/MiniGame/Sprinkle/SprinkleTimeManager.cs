using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinkleTimeManager : MonoBehaviour
{
    public float time; //SprinkleTime
    public bool IsEnded = false; //Express the Sprinkle is Ended-this point
    public bool IsChcking = false; //Express Player is clicking
    [SerializeField] SprinkleManager sprinkleManager;

    private void Start()
    {
        time -= SkillManagement.Instance.HandMaster();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Mouse"))
        {
            IsChcking = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Mouse"))
        {
            IsChcking = false;
        }
    }

    void Update()
    {
        if(IsChcking)
        {
            time -= Time.deltaTime;
        }
       
        if (time <= 0)
        {
            IsEnded = true;
        }

    }

}
