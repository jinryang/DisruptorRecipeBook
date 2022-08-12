using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{
    private Vector3 before;
    private Vector3 first;
    public bool isMoving = false;
    public bool onAble = false;
    public int ID = -1;


    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            if (!CreateRaw.Instance.place[i])
            {
                CreateRaw.Instance.place[i] = true;
                ID = i;
                first = this.transform.position;
                break;
            }
        }
    }

    private void OnMouseDown()
    {
        before = transform.position;
        isMoving = true;
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
        else if (before == first)
        {
            CreateRaw.Instance.RemovePlace(ID);
        }
        isMoving = false;
    }

    public void ResetPoint()
    {
        this.transform.position = before;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Finish")
        {
            if (before == first)
            {
                CreateRaw.Instance.RemovePlace(ID);
            }
            GameObject.Find("SpawnManager").GetComponent<CreateRaw>().GetScore(GetComponent<Degree>().Point());
            Destroy(this.gameObject);
        }
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
}
