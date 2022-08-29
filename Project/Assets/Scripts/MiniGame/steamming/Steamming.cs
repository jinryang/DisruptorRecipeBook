using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steamming : MonoBehaviour
{
    [SerializeField] SourceManager[] sourceManagers;
    [SerializeField] int[] sectionOfScore;
    private int numOfInDishes = 0;
    private int score = 0;

    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(IsEnded());
        if (score == 0   && numOfInDishes == sourceManagers.Length)
        {
            Debug.Log("ScoreCalcul");
            StartCoroutine(ScoreCalcul());
        }
    }

    IEnumerator IsEnded()
    {
        numOfInDishes = 0;
        for (int i = 0; i < sourceManagers.Length; ++i)
        {
            if (sourceManagers[i].GetIsOnRight())
            {
                ++numOfInDishes;
            }
        }

        yield return null;
    }

    IEnumerator ScoreCalcul()
    {
        for(int i = 0; i < sourceManagers.Length; ++i)
        {
            if(sourceManagers[i].stepOfCooked == 1)
            {
                score += sectionOfScore[0];
            }
            else if(sourceManagers[i].stepOfCooked == 2)
            {
                score += sectionOfScore[1];
            }
            else if (sourceManagers[i].stepOfCooked == 3)
            {
                score += sectionOfScore[2];
            }
            else if (sourceManagers[i].stepOfCooked == 4)
            {
                score += sectionOfScore[3];
            }
            else if (sourceManagers[i].stepOfCooked == 5)
            {
                score += sectionOfScore[4];
            }
            else if (sourceManagers[i].stepOfCooked > 5)
            {
                score += sectionOfScore[5];
            }
        }

        yield return null;
    }

}
