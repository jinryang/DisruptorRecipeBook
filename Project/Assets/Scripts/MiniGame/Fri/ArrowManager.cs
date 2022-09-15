using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowManager : MonoBehaviour
{
    [SerializeField] FriManager Frimanager;
    public Image[] image;
    public float FadeInSpeed = 0.02f;
    public float FadeOutSpeed = 0.03f;
    private float FadeCount = 0;
    private int target = -1;
    private int lastTarget = -1;
    private bool FadeIn = false;

    void Start()
    {
        for (int i = 0; i < image.Length; ++i)
        {
            image[i].color = new Color(255, 255, 255, FadeCount);
        }
        target = Frimanager.GetFriWay() - 1;
        StartCoroutine(FadeInManager());
        FadeInSpeed /= 100;
        FadeOutSpeed /= 100;
        lastTarget = target;
    }
    void Update()
    {
        #region Debug
        /*
        Debug.Log(FadeCount);*/
        #endregion

        if (FadeIn == true)
        {
            StartCoroutine(FadeInManager());
        }
        else
        {
            StartCoroutine(FadeOutManager());
        }

        target = Frimanager.GetFriWay() - 1;

        image[target].color = new Color(255, 255, 255, FadeCount);

        if (lastTarget >= 0 && lastTarget != target)
        {
            StopCoroutine(FadeInManager());
            StopCoroutine(FadeOutManager());
            image[lastTarget].color = new Color(1, 1, 1, 0f);
            Debug.Log("..." + image[lastTarget].color.a + " " + image[lastTarget].name);
            lastTarget = target;
        }

        if (FadeCount != image[target].color.a) { FadeCount = image[target].color.a; }

    }
    IEnumerator FadeInManager()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
        while (FadeCount <= 1)
        {
            FadeCount += FadeInSpeed;
            yield return waitForSeconds;
        }
        FadeIn = false;
    }
    IEnumerator FadeOutManager()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
        while (FadeCount >= 0f)
        {
            FadeCount -= FadeOutSpeed;
            yield return waitForSeconds;
        }
        FadeIn = true;
    }
}

