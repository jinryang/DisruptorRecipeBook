using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{
    private Vector3 before;
    public bool isMove;
    public bool onAble;
    public int ID;


    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            if (!CreateRaw.Instance.place[i])
            {
                CreateRaw.Instance.place[i] = true;
                ID = i;
                break;
            }
        }
    }

    private void OnMouseDown()
    {
        before = transform.position;
    }

    private void OnMouseDrag()
    {
        this.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position += Vector3.forward * 10;
    }

    private void OnMouseUp()
    {
        if (!onAble)
        {
            ResetPoint();
        }
        CreateRaw.Instance.RemovePlace(ID);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("StayAble"))
        {
            onAble = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("StayAble"))
        {
            onAble = false;
        }
    }
    public void ResetPoint()
    {
        this.transform.position = before;
    }
}
