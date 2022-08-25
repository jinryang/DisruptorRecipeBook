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
    public Transform droptransform;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        stop = 0;
        pos = transform.position;
    }
    void FixedUpdate()
    {
        Vector3 v = pos;
        rigid.gravityScale = 0;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
        if (stop == 1)
        {
            Instantiate(drop,droptransform.position,droptransform.rotation);
            stop = 0;
        }

    }
}
