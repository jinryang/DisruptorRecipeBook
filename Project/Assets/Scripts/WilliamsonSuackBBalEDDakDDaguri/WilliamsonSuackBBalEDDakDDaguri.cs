using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WilliamsonSuackBBalEDDakDDaguri : MonoBehaviour
{
    #region Singleton
    private static WilliamsonSuackBBalEDDakDDaguri instance;
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
    }
    public static WilliamsonSuackBBalEDDakDDaguri Instance
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
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RecipeDatas.Instance.GetRecipe(0);
        }
        else if (Input.GetKey(KeyCode.C))
        {
            RecipeDatas.Instance.GetRecipe(3);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Data.Instance.InitData();
        }
    }
}
