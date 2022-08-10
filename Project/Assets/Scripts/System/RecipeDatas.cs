using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeDatas : MonoBehaviour
{
    #region Singleton
    private static RecipeDatas instence;
    private void Awake()
    {
        if (null == instence)
        {
            instence = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        BackUpBone = Recipes;
        LoadRecipe();
    }
    #endregion

    [System.Serializable]
    public class RecipeInfo
    {
        public string Name;
        public Sprite Image;
        public bool isHold = false;
    }

    [SerializeField]
    public List<RecipeInfo> Recipes;

    public List<RecipeInfo> BackUpBone;
    public void LoadRecipe()
    {
        Recipes = PlayerDataSaveSystem.Instance.LoadData().recipes;
    }
}
