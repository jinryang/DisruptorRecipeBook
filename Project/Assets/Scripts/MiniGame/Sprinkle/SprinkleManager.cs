using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinkleManager : MonoBehaviour
{
    [SerializeField] SprinkleTimeManager[] sprinklePos;
    public int InteractPos = 0; // number of interacting SprinklePos
    private int cnt = 0; // number of endedPos
    private int score;
    private float time;
    private bool IsClick = false;
    public GameObject Timer;

    void Start()
    {
        score = 0;
        time = 0;
    }

    void Update()
    {
        if (Timer.GetComponent<CookTimer>().timer <= 0)
        {
            Finish();
        }
        if (Input.GetMouseButtonDown(1))
        {
            IsClick = true;
        }
        if (IsClick)
        {
            time += Time.deltaTime;
        }
        cnt = 0;
        for (int i = 0; i < 4; i++)
        {
            if (sprinklePos[i].IsEnded == true)
            {
                cnt++;
            }
            if (cnt == 4)
            {
                Finish();
            }
        }

    }

    public void Finish()
    {
        for (int i = 0; i < 4; i++)
        {
            if (sprinklePos[i].IsEnded)
                score += (int)(100 * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.TimeAttackPoint() * SkillManagement.Instance.LastSpurt(Timer.GetComponent<CookTimer>().timer));
            else
                score -= (int)(50 * SkillManagement.Instance.CookingGodBlessing(50, -50));
        }
        MinigameManagement.Instance.SetScore(score);
        MinigameManagement.Instance.GoTutorial();
    }
}
