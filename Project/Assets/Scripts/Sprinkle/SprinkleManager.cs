using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinkleManager : MonoBehaviour
{
    [SerializeField] GameObject sprinklePos1;
    [SerializeField] GameObject sprinklePos2;
    [SerializeField] GameObject sprinklePos3;
    [SerializeField] GameObject sprinklePos4;
    public int interactPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Sprinkle()
    {

        yield return null;
    }
}
