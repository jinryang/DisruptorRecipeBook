using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Point po;
    public Temperature tem;

    bool a = false;
    public bool reset;
    public bool stop;
    public float time = 20;
    public GameObject tembutton;
    public GameObject temb;
    public Image temg;
    public Text TimeText;
    public Text outTime;

    public int tempoint;
    public int timepoint;
    // Start is called before the first frame update
    void Start()
    {
        a = false;
        reset = false;
        stop = false;
        time = 20;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (stop == false)
        {
            if (time > 0)
                time -= Time.deltaTime;
            else
            {
                time = 0;
                tembutton.SetActive(false);

                if (!a)
                {
                    AddTemPoint();
                    po.AddPoint(tempoint);
                    temb.SetActive(true);
                    outTime.GetComponent<Text>().enabled = true;
                    Invoke("TimeReset", 3.0f);
                }
            }
        }
        if (a)
        {
            AddTimePoint();
            po.AddPoint(timepoint + tempoint);
            MinigameManagement.Instance.SetScore(timepoint + tempoint);
            MinigameManagement.Instance.GoTutorial();
        }
        TimeText.text = string.Format("{0:N2}", time);
        if (tem.nowtem <= 165 && tem.nowtem >= 155)
            temg.color = Color.green;
        else if (tem.nowtem <= 170 && tem.nowtem >= 140)
            temg.color = Color.yellow;
        else if (tem.nowtem <= 180 && tem.nowtem >= 120)
            temg.color = new Color(255, 161, 0, 255);
        else if (tem.nowtem <= 190 && tem.nowtem > 100)
            temg.color = Color.red;
        else if (tem.nowtem <= 200 && tem.nowtem > 100)
            temg.color = Color.black;
        else if (tem.nowtem <= 100)
            temg.color = Color.blue;
    }
    public void OutButton()
    {
        stop = true;
        temb.SetActive(true);
        a = true;
    }
    public void TimeReset()
    {
        time = 20.02f;
        temb.SetActive(false);

    }
    public void AddTemPoint()
    {
        if (tem.nowtem <= 165 && tem.nowtem >= 155)
            tempoint = 100;
        else if (tem.nowtem <= 170 && tem.nowtem >= 140)
            tempoint = 70;
        else if (tem.nowtem <= 180 && tem.nowtem >= 120)
            tempoint = 50;
        else if (tem.nowtem <= 190 && tem.nowtem > 100)
            tempoint = 30;
        else if (tem.nowtem <= 200)
            tempoint = 10;
        else if (tem.nowtem <= 100)
            tempoint = 10;
        tempoint = (int)(tempoint * SkillManagement.Instance.CookingMaster());
    }
    public void AddTimePoint()
    {
        if (time >= 9.5 && time <= 10.5 && stop)
            timepoint = 100;
        else if (time >= 8 && time <= 12 && stop)
            timepoint = 60;
        else if (time >= 6 && time <= 15 && stop)
            timepoint = 30;
        else if (time >= 3 && stop)
            timepoint = (int)(10 * SkillManagement.Instance.CookingGodBlessing(10, 30));
        timepoint = (int)(timepoint * SkillManagement.Instance.CookingMaster());
    }
}