using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeButton : MonoBehaviour
{
    public GameObject ItemList;
    public GameObject InObject;
    public GameObject[] skills;
    public Sprite[] icons;

    public void ItemListClick()
    {
        ItemList.SetActive(true);
    }
    public void InButton()
    {
        InObject.SetActive(false);
        ItemList.SetActive(false);

        if (skills[0].transform.GetChild(1).gameObject.active)
        {
            if (skills[1].transform.GetChild(1).gameObject.active)
            {
                skills[2].transform.GetChild(1).gameObject.GetComponent<Image>().sprite = icons[int.Parse(transform.parent.gameObject.name)];
                skills[2].transform.GetChild(1).gameObject.SetActive(true);
                SkillManagement.Instance.SetUsingSkill(int.Parse(transform.parent.gameObject.name));
                skills[2].SetActive(false);
            }
            else
            {
                skills[1].transform.GetChild(1).gameObject.GetComponent<Image>().sprite = icons[int.Parse(transform.parent.gameObject.name)];
                skills[1].transform.GetChild(1).gameObject.SetActive(true);
                SkillManagement.Instance.SetUsingSkill(int.Parse(transform.parent.gameObject.name));
                skills[1].SetActive(false);
            }
        }
        else
        {
            skills[0].transform.GetChild(1).gameObject.GetComponent<Image>().sprite = icons[int.Parse(transform.parent.gameObject.name)];
            skills[0].transform.GetChild(1).gameObject.SetActive(true);
            SkillManagement.Instance.SetUsingSkill(int.Parse(transform.parent.gameObject.name));
            skills[0].SetActive(false);
        }
        Destroy(transform.parent.gameObject);
    }
}
