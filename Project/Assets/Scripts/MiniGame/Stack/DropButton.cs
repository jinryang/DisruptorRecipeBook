using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropButton : MonoBehaviour
{
    public GameObject drop;
    public Move move;
    public int StopDrop = 0;
    public int maxDrop = 0;
    // Start is called before the first frame update
    void Start()
    {
        Move move = GetComponent<Move>();
        StopDrop = 0;
    }

    // Update is called once per frame
    public void Drop()
    {
        StopDrop += 1;
        if(StopDrop <= maxDrop)
            move.stop = 1;
        else
        {
            Invoke("MoveScene", 3.5f);
        }
    }
    
    public void MoveScene()
    {
        MinigameManagement.Instance.GoTutorial();
    }
}
