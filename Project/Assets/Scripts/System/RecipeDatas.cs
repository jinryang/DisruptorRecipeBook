using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeDatas : MonoBehaviour
{
    #region Singleton
    private static RecipeDatas instance;
    private void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        BackUpBone = Recipes;
        LoadRecipe();
    }
    public static RecipeDatas Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    #endregion

    [System.Serializable]
    public class RecipeInfo
    {
        public string Name;
        public Sprite Food;
        public Sprite Cooks;
        public bool isHold = false;
        public int[] moveScene;
    }

    [SerializeField]
    public List<RecipeInfo> Recipes;
    public List<RecipeInfo> BackUpBone;

    public void GetRecipe(int _idx)
    {
        Recipes[_idx].isHold = true;
        Data.Instance.SaveRecipes(Recipes);
    }

    public void LoadRecipe()
    {
        Recipes = Data.Instance.LoadData().recipes;
    }
}
