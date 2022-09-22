using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropButton : MonoBehaviour
{
    public GameObject drop;
    public Move move;
    public int StopDrop = 0;
    public int maxDrop = 0;

    public SpriteRenderer burger;
    public SpriteRenderer burger2;
    public Sprite[] images;
    int Layer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Move move = GetComponent<Move>();
        StopDrop = 0;
        burger.sprite = images[StopDrop];
        burger2.sprite = images[StopDrop];
    }

    // Update is called once per frame
    public void Drop()
    {
        Layer++;
        burger.GetComponent<SpriteRenderer>().sortingOrder = -10 + Layer;
        StopDrop += 1;
        if(StopDrop <= maxDrop)
            move.stop = 1;
        else
        {
            Invoke("MoveScene", 3.5f);
        }
        burger.sprite = images[StopDrop - 1];
        burger2.sprite = images[StopDrop];
        
    }
    
    public void MoveScene()
    {
        MinigameManagement.Instance.GoTutorial();
    }
}
