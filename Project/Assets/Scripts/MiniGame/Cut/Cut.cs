using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cut : MonoBehaviour
{
    public CutTimer cuttimer;
    public Slider CutSlider;
    public int MaxCut = 100;
    public float NowCut = 0;
    public float CutSpeed = 2;
    public GameObject TimeStop;
    public GameObject cover;
    public Text CutText;
    public int CutPoint = 0;

    public Image Meet;
    public Sprite[] MeetImage;
    // Start is called before the first frame update
    void Start()
    {
        TimeStop.SetActive(true);
        CutPoint = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CutSlider.value = NowCut;
        if (NowCut >= 100)
        {
            NowCut = 100;
            TimeStop.SetActive(false);
            cover.SetActive(true);
            CutPoint = (int)(100 * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.TimeAttackPoint() * SkillManagement.Instance.Perfectionist() * SkillManagement.Instance.LastSpurt(cuttimer.time));
            MinigameManagement.Instance.SetScore(CutPoint);
            Invoke("GoTuto", 2);
        }
        else if (NowCut >= 70 && cuttimer.cuttimepoint == true)
        {
            TimeStop.SetActive(false);
            cover.SetActive(true);
            CutPoint = (int)(70 * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.TimeAttackPoint() * SkillManagement.Instance.LastSpurt(cuttimer.time));
        }
        else if (NowCut >= 50 && cuttimer.cuttimepoint == true)
        {
            TimeStop.SetActive(false);
            cover.SetActive(true);
            CutPoint = (int)(50 * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.TimeAttackPoint() * SkillManagement.Instance.LastSpurt(cuttimer.time));
        }
        else if (NowCut >= 30 && cuttimer.cuttimepoint == true)
        {
            TimeStop.SetActive(false);
            cover.SetActive(true);
            CutPoint = (int)(30 * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.TimeAttackPoint() * SkillManagement.Instance.LastSpurt(cuttimer.time));
        }
        else if (NowCut < 30 && cuttimer.cuttimepoint == true)
        {
            TimeStop.SetActive(false);
            cover.SetActive(true);
            CutPoint = (int)(10 * SkillManagement.Instance.CookingMaster() * SkillManagement.Instance.TimeAttackPoint() * SkillManagement.Instance.LastSpurt(cuttimer.time));
        }
        CutText.text = "point : " + CutPoint;
        CutImage();
    }
    public void CutButton()
    {
        NowCut += CutSpeed;
    }
    public void CutImage()
    {
        if (NowCut >= 100)
        {
            Meet.transform.localRotation = Quaternion.Euler(0, 0, -10);
        }
        else if (NowCut >= 90)
        {
            Meet.sprite = MeetImage[2];
        }
        else if (NowCut >= 80)
        {
            Meet.transform.localRotation = Quaternion.Euler(0, 0, 4);
        }
        else if (NowCut >= 70)
        {
            Meet.transform.localRotation = Quaternion.Euler(0, 0, -3);
        }
        else if (NowCut >= 60)
        {
            Meet.transform.localRotation = Quaternion.Euler(0, 0, 5);
        }
        else if (NowCut >= 50)
        {
            Meet.transform.localRotation = Quaternion.Euler(0, 0, -6);
        }
        else if (NowCut >= 40)
        {
            Meet.transform.localRotation = Quaternion.Euler(0, 0, 2);
        }
        else if (NowCut >= 30)
        {
            Meet.transform.localRotation = Quaternion.Euler(0, 0, -1);
        }
        else if (NowCut >= 20)
        {
            Meet.sprite = MeetImage[1];
        }
        else if (NowCut >= 10)
        {
            Meet.transform.localRotation = Quaternion.Euler(0, 0, -1);
        }
    }
    private void GoTuto()
    {
        MinigameManagement.Instance.GoTutorial();
    }
}
