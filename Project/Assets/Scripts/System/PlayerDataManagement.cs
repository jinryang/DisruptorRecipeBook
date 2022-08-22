using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataManagement : MonoBehaviour
{
    #region Singleton
    private static PlayerDataManagement instance;
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
        LoadPlayerData();
    }
    public static PlayerDataManagement Instance
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

    public int point = 0;

    public void LoadPlayerData()
    {
        point = Data.Instance.LoadData().point;
    }

    public void PlusPoint(int _point)
    {
        point += _point;
        Data.Instance.SavePoint(0);
    }
}
