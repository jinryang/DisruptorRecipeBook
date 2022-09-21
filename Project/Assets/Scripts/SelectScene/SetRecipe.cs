using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRecipe : MonoBehaviour
{
    public int recipeNum = 0;

    void Start()
    {
        this.transform.GetChild(2).GetComponent<Image>().sprite
            = RecipeDatas.Instance.Recipes[recipeNum].Food;
        this.transform.GetChild(3).GetChild(0).GetComponent<Text>().text
            = RecipeDatas.Instance.Recipes[recipeNum].Order.Replace("\\n","\n");
    }

    public void GameStart()
    {
        MinigameManagement.Instance.SelectRecipe(recipeNum);
        MinigameManagement.Instance.GoTutorial();
    }
}
