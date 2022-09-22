using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public PlayerPoint ppoint;
    public int BuyPoint = 0;
    public GameObject nopoint;
    public Text BuyPointText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        BuyPointText.text = "ºñ¿ë : " + BuyPoint;
    }
    public void Buy()
    {
        if (ppoint.NowPoint >= BuyPoint)
        {
            ppoint.NowPoint -= BuyPoint;
            PlayerDataManagement.Instance.MinusPoint(BuyPoint);
            RecipeDatas.Instance.GetRecipe(int.Parse(transform.parent.name));
            Destroy(gameObject);
        }
        else
        {
            nopoint.SetActive(true);
            Invoke("YouDoNotHavePoint", 2.0f);
        }
    }
    public void BuySkill()
    {
        if (ppoint.NowPoint >= BuyPoint)
        {
            ppoint.NowPoint -= BuyPoint;
            PlayerDataManagement.Instance.MinusPoint(BuyPoint);
            SkillManagement.Instance.GetSkill(int.Parse(transform.parent.name));
            Destroy(gameObject);
        }
        else
        {
            nopoint.SetActive(true);
            Invoke("YouDoNotHavePoint", 2.0f);
        }
    }
    void YouDoNotHavePoint()
    {
        nopoint.SetActive(false);
    }
}
