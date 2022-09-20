using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpDropPoint : MonoBehaviour
{
    public DropPoint dropPoint;
    public int UPDP = 0;
    // Start is called before the first frame update
    void Start()
    {
        dropPoint = FindObjectOfType<DropPoint>();
        if (transform.position.x >= -1 && transform.position.x <= 1)
        {
            UPDP = 50;
            MinigameManagement.Instance.PlusScore(UPDP);
            dropPoint.DP += UPDP;
        }
        else if(transform.position.x >= -3 && transform.position.x <= 3)
        {
            UPDP = 30;
            MinigameManagement.Instance.PlusScore(UPDP);
            dropPoint.DP += UPDP;
        }
        else if (transform.position.x >= -6 && transform.position.x <= 6)
        {
            UPDP = 20;
            MinigameManagement.Instance.PlusScore(UPDP);
            dropPoint.DP += UPDP;
        }
        else if (transform.position.x >= -10 && transform.position.x <= 10)
        {
            UPDP = 1;
            MinigameManagement.Instance.PlusScore(UPDP);
            dropPoint.DP += UPDP;
        }
    }
}
