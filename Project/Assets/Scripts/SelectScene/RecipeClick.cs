using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeClick : MonoBehaviour
{
    [SerializeField] private int number;

    private void Start()
    {
        if (RecipeDatas.Instance.Recipes[int.Parse(this.gameObject.name) - 1].isHold)
        {
            GetComponent<Button>().enabled = true;
            GetComponent<Image>().color = new Color(1, 1, 1);
        }
        else
        {
            GetComponent<Button>().enabled = false;
            GetComponent<Image>().color = new Color(0.2f, 0.2f, 0.2f);
        }
    }

    public void CookingClick()
    {
        GameObject rcip = Resources.Load<GameObject>("Recipes");
        rcip.GetComponent<SetRecipe>().recipeNum = number;
        Instantiate(rcip, GameObject.Find("Canvas").transform);
    }
}
