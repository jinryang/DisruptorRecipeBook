using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeButton : MonoBehaviour
{
    public GameObject ItemList;
    public GameObject InObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ItemListClick()
    {
        ItemList.SetActive(true);
    }
    public void InButton()
    {
        InObject.SetActive(false);
        ItemList.SetActive(false);
    }
    public void OutButton()
    {
        InObject.SetActive(true);
        ItemList.SetActive(false);
    }
}
