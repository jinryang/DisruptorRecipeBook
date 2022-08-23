using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 pos;
    private Rigidbody2D rigid;
    public float delta = 10.0f;
    public float speed = 1.0f;
    public int stop = 0;
    public GameObject drop;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        stop = 0;
        pos = transform.position;
        rigid.gravityScale = 0;
    }
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            stop = 1;
            Instantiate(drop);
        }
        Vector3 v = pos;
        if(stop == 0)
        {
            rigid.gravityScale = 0;
            v.x += delta * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
        if (stop == 1)
        {
            rigid.gravityScale = 0.5f;
        }

    }
}
