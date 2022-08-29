using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceManager : MonoBehaviour
{

    [SerializeField] float sectionOfCooking = 10.0f;
    private float tempsection;

    Vector3 savePos;
    private WaitForEndOfFrame waitframe = new WaitForEndOfFrame();

    private bool IsOnBase = false;
    private bool IsOnRight = false;

    public int stepOfCooked = 1; //Steps To Indicate Cooked. For example) 1, raw / 2, little cooked / 3, perfectly cooked / 4, over cooked / 5, burnt  

    public float timeOfPutOnRightDish = 0.5f; //recommend 0.5sec
    public float Speed = 5; //Speed Of Lerf Calculation
    
    void Start()
    {
        savePos = gameObject.transform.position;
        tempsection = sectionOfCooking;
    }

    
    void Update()
    {
        
        if(Input.GetMouseButtonUp(0) && !IsOnBase)
        { 
            StartCoroutine(MoveTo());
        }

        if (IsOnBase == true)
        {
            if(sectionOfCooking <= 0)
            {
                sectionOfCooking = tempsection;
                ++stepOfCooked;
            }
            sectionOfCooking -= Time.deltaTime;
            
        }
    }
    private void OnMouseDrag()
    {
        if(!IsOnRight)
        {
            Vector2 MousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 WorldObjPosition = Camera.main.ScreenToWorldPoint(MousePosition);
            gameObject.transform.position = WorldObjPosition;
        }
    }

    public bool GetIsOnRight()
    {
        return IsOnRight;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Pot"))
        {
            IsOnBase = true;
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("RightDish"))
        {
           
            timeOfPutOnRightDish -= Time.deltaTime;
            if(timeOfPutOnRightDish <= 0)
            {
                IsOnRight = true;
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Pot"))
        {
            IsOnBase = false;
        }
    }

    IEnumerator MoveTo()
    {
        if (!IsOnRight)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("ColliderIsEnabled");
            WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
            while (true)
            {
                yield return waitForEndOfFrame;
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, savePos, Time.deltaTime * Speed);

                if (Vector3.Distance(transform.position, savePos) < 0.01f)
                {
                    gameObject.GetComponent<BoxCollider2D>().enabled = true;
                    break;
                }
            }
        }
        yield return null;
    }
}