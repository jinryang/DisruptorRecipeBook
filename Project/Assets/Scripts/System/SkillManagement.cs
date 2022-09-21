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
        BackUpBone = Skills;
        LoadSkill();
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

    [System.Serializable]
    public class SkillInfo
    {
        public string Name;
        public string Information;
        public Sprite Image;
        public bool isHold = false;
    }

    [SerializeField]
    public List<SkillInfo> Skills;
    public List<SkillInfo> BackUpBone;

    public void GetSkill(int _idx)
    {
        Skills[_idx].isHold = true;
        Data.Instance.SaveSkill(Skills);
    }

    public void LoadSkill()
    {
        Skills = Data.Instance.LoadData().skills;
    }
}
