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

    private static int point = 0;
    public static int Point
    {
        get { return point; }
    }


    public void LoadPlayerData()
    {
        point = Data.Instance.LoadData().point;
    }

    public void PlusPoint(int _point)
    {
        point += _point;
        Data.Instance.SaveData(null,null,0);
    }
}
