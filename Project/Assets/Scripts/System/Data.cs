using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

public class Data : MonoBehaviour
{
    #region Singleton
    private static Data instance;
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
    public static Data Instance
    {
        get
        {
            if (null == instance)
            {
                instance = null;
            }
            return instance;
        }
    }
    #endregion

    [System.Serializable]
    public class JsonData
    {
        public int point = 0;
        public List<RecipeDatas.RecipeInfo> recipes;
        public List<SkillManagement.SkillInfo> skills;
        public bool isFirst = true;
    }
    #region Save&Load

    private void Start()
    {
        if (instance.LoadData().isFirst)
        {
            InitData();
            SaveData(RecipeDatas.Instance.BackUpBone, false);
        }
    }
    public void SaveData(List<RecipeDatas.RecipeInfo> _recipes = null, bool _isfirst = false, List<SkillManagement.SkillInfo> _skill = null, int _point = -1)
    {
        Debug.Log(Application.persistentDataPath);
        JsonData data = new JsonData();

        if (null == _recipes) data.recipes = LoadData().recipes;
        else data.recipes = _recipes;

        if (null == _skill) data.skills = LoadData().skills;
        else data.skills = _skill;

        if (-1 == _point) data.point = LoadData().point;
        else data.point = _point;

        data.isFirst = _isfirst;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public JsonData LoadData()
    {
        Debug.Log(Application.persistentDataPath);
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            JsonData data = JsonUtility.FromJson<JsonData>(json);
            return data;
        }
        else
        {
            Debug.Log("Null Refrenece on LoadData()");
            return null;
        }
    }
    public void InitData()
    {
        SaveData(RecipeDatas.Instance.BackUpBone,true);
        RecipeDatas.Instance.LoadRecipe();
        SkillManagement.Instance.LoadSkill();
    }
    #endregion
}
