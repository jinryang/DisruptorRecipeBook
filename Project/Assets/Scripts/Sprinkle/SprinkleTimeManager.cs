using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinkleTimeManager : MonoBehaviour
{
    public float time;
    public int posInfo;
    [SerializeField] SprinkleManager sprinkleManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sprinkleManager.interactPos == posInfo)
        {
            time -= Time.deltaTime;
        }
    }
}
