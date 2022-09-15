using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
        transform.position = Camera.main.ScreenToWorldPoint(MousePos);
    }
}
