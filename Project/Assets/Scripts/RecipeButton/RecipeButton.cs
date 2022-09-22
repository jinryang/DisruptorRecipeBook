using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeButton : MonoBehaviour
{
    public GameObject ItemList;
    public GameObject InObject;

    public void ItemListClick()
    {
        ItemList.SetActive(true);
    }
    public void InButton()
    {
        InObject.SetActive(false);
        ItemList.SetActive(false);
        Destroy(transform.parent.gameObject);
    }
    public void OutButton()
    {
        InObject.SetActive(true);
        ItemList.SetActive(false);
    }
}
