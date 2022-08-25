using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeClick : MonoBehaviour
{
    [SerializeField] private int number;

    public void CookingClick()
    {
        GameObject rcip = Resources.Load<GameObject>("Recipes");
        rcip.GetComponent<SetRecipe>().recipeNum = number;
        Instantiate(rcip, GameObject.Find("Canvas").transform);
    }
}
