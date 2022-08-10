using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManagement : MonoBehaviour
{
    #region Singleton
    private static SkillManagement instance;
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
    public static SkillManagement Instance
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

    public void GetSkill(int num)
    {
        switch (num)
        {
            case 0:
                break;
        }
        PlayerDataSaveSystem.Instance.SaveSkills(this);
    }
}
