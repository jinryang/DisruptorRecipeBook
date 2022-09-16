using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gipo : MonoBehaviour
{
    GgulIGiManager ggulIGiManager;
    public float time = 1.5f;
    void Start()
    {

    }
    private void Awake()
    {
        ggulIGiManager = GameObject.Find("BaDak").GetComponent<GgulIGiManager>();
    }

    void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mouse") && Input.GetMouseButton(0))
        {
            ggulIGiManager.addScore();
            Destroy(gameObject);
        }
    }
}
