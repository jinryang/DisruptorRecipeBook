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
    public bool IsOnRight = false;
    private bool IsClicked = false;

    public int stepOfCooked = 1; //Steps To Indicate Cooked. For example) 1, raw / 2, little cooked / 3, perfectly cooked / 4, over cooked / 5, burnt  

    public float timeOfPutOnRightDish = 0.5f; //recommend 0.5sec
    public float Speed = 1; //Speed Of Lerf Calculation
    
    void Start()
    {
        savePos = gameObject.transform.position;
        tempsection = sectionOfCooking;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            IsClicked = true;
        }
        if(Input.GetMouseButtonUp(1))
        {
            IsClicked = false;
            StopAllCoroutines();
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
        if(IsClicked)
        {
            gameObject.transform.position = Input.mousePosition;
        }
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
                gameObject.GetComponent<BoxCollider>().enabled = true;
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
        gameObject.GetComponent<BoxCollider>().enabled = true;

        WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
        while (!IsOnBase)
        {
            yield return waitForEndOfFrame;
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, savePos, Time.deltaTime * Speed);

            if (Vector3.Distance(transform.position, savePos) < 0.01f)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;
                break;
            }
        }

        yield return null;
    }
}