using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFoodImage : MonoBehaviour
{
    GameObject game;
    [SerializeField] SpriteRenderer spriteRender;
    [SerializeField] Sprite targetSprite;
    void Start()
    {
        spriteRender.sprite = targetSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
