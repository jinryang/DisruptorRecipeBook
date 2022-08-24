using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropButton : MonoBehaviour
{
    public GameObject drop;
    public GameObject droppo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Drop()
    {
        Instantiate(drop,(droppo.gameObject.transform));
    }
}
