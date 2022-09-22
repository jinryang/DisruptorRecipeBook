using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GgulIGiManager : MonoBehaviour
{
    [SerializeField] GameObject Bubble;
    public float BubbleSummonTime = 0.3f;
    private float tempTime;
    GameObject Timer;
    float time;

    private void Start()
    {
        Timer = GameObject.Find("Canvas").transform.GetChild(0).gameObject;
        time = Timer.GetComponent<CookTimer>().timer;
        tempTime = BubbleSummonTime;
    }

    // Update is called once per frame
    void Update()
    {
        BubbleSummonTime -= Time.deltaTime;
        if (BubbleSummonTime <= 0)
        {
            BubbleSummonTime = tempTime;

            float x = Random.Range(-3.75f, 3.75f);
            float y = Random.Range(-3.75f, 3.75f);
            WaitForSeconds wait = new WaitForSeconds(0.3f);
            Instantiate(Bubble, new Vector3(x, y, 1), Quaternion.identity);
        }
    }
    public void addScore()
    {
        MinigameManagement.Instance.PlusScore((int)(20 *SkillManagement.Instance.CookingMaster()* SkillManagement.Instance.TimeAttackPoint() * SkillManagement.Instance.LastSpurt(time)));
    }
}
