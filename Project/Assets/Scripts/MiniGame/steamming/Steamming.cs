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
        if (numOfInDishes == sourceManagers.Length)
        {
            StartCoroutine(ScoreCalcul());
        }
    }

    IEnumerator IsEnded()
    {
        numOfInDishes = 0;
        for (int i = 0; i < sourceManagers.Length; ++i)
        {
            if (sourceManagers[i].IsOnRight)
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
                score += sectionOfScore[i];
            }
            else if(sourceManagers[i].stepOfCooked == 2)
            {
                score += sectionOfScore[i];
            }
            else if (sourceManagers[i].stepOfCooked == 3)
            {
                score += sectionOfScore[i];
            }
            else if (sourceManagers[i].stepOfCooked == 4)
            {
                score += sectionOfScore[i];
            }
            else if (sourceManagers[i].stepOfCooked == 5)
            {
                score += sectionOfScore[i];
            }
        }

        yield return null;
    }

}
