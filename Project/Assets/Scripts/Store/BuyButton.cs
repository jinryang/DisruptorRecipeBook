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
        BuyPointText.text = "��� : " + BuyPoint;
    }
    public void Buy()
    {
        Destroy(gameObject);
        if(ppoint.NowPoint >= BuyPoint)
        {
            ppoint.NowPoint -= BuyPoint;
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

    public void BackButton()
    {
        SceneManager.LoadScene(gameObject.name);
    }
}
