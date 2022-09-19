using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
        Vector3 MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        transform.position = Camera.main.ScreenToWorldPoint(MousePos);
    }
}
