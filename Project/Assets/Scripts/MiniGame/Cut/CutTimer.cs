using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CutTimer : MonoBehaviour
{
    public float time = 10;
    public Text TimeText;
    public GameObject cover;
    public bool cut;
    public bool cuttimepoint;
    public GameObject CutButton;
    // Start is called before the first frame update
    void Start()
    {
        time = 10 + SkillManagement.Instance.PlusTime() - SkillManagement.Instance.TimeAttackTime();
        cover.SetActive(false);
        cut = true;
        cuttimepoint = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (time > 0)
            time -= Time.deltaTime;
        else
        {
            cuttimepoint = true;
            time = 0;
            cover.SetActive(true);
            cut = false;
            MinigameManagement.Instance.SetScore(CutButton.GetComponent<Cut>().CutPoint);
            MinigameManagement.Instance.GoTutorial();
        }
        TimeText.text = string.Format("{0:N2}", time);
    }
}