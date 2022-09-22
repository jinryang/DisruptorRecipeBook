using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gipo : MonoBehaviour
{
    GgulIGiManager ggulIGiManager;
    public float time = 1.5f;
    public float popTime = 0.5f;
    void Start()
    {

    }
    private void Awake()
    {
        ggulIGiManager = GameObject.Find("HotWater").GetComponent<GgulIGiManager>();
    }

    void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Mouse") && Input.GetMouseButton(0))
        {
            popTime -= Time.deltaTime;
            if (popTime < 0)
            {
                ggulIGiManager.addScore();
                Destroy(gameObject);
            }
        }
    }
}
