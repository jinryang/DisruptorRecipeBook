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
    private int[] usingIdx;

    public void GetSkill(int _idx)
    {
        Skills[_idx].isHold = true;
        Data.Instance.SaveSkill(Skills);
    }

    public void LoadSkill()
    {
        Skills = Data.Instance.LoadData().skills;
    }

    public void SetUsingSkill(int[] _idx)
    {
        usingIdx = _idx;
    }

    public float PlusTime()
    {
        int i = 0;
        if (usingIdx[0] == i || usingIdx[1] == i || usingIdx[2] == i)
            if (Skills[i].isHold)
                return 10;
        return 0;
    }
    public float Perfectionist()
    {
        int i = 1;
        if (usingIdx[0] == i || usingIdx[1] == i || usingIdx[2] == i)
            if (Skills[i].isHold)
                return 1.5f;
        return 1;
    }
    public float ManyWings()
    {
        int i = 2;
        if (usingIdx[0] == i || usingIdx[1] == i || usingIdx[2] == i)
            if (Skills[i].isHold)
                return 10f;
        return 0;
    }
    public float SharpEdge()
    {
        int i = 3;
        if (usingIdx[0] == i || usingIdx[1] == i || usingIdx[2] == i)
            if (Skills[i].isHold)
                return 1.25f;
        return 1;
    }
}
