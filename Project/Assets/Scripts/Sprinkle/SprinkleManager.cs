using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinkleManager : MonoBehaviour
{
    [SerializeField] SprinkleTimeManager[] sprinklePos = new SprinkleTimeManager[4];
    public int InteractPos = 0; // number of interacting SprinklePos
    private int cnt = 0; // number of endedPos
    void Start()
    {
        
    }

    void Update()
    {
        cnt = 0;
        for(int i = 0; i < 4; i++)
        {
            if(sprinklePos[i].IsEnded == true)
            {
                cnt++;
            }
            if(cnt == 4)
            {
                Debug.Log("End");
                //»Ñ¸®±â ³¡
            }
        }
        
    }

    

    
}
