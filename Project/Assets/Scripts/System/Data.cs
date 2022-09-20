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
        if (!File.Exists(Application.persistentDataPath + "/savefile.json"))
        {
            InitData();
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
    }
    #region Save&Load

    public void SaveData(List<RecipeDatas.RecipeInfo> _recipes, List<SkillManagement.SkillInfo> _skill, int _point)
    {
        Debug.Log(Application.persistentDataPath);
        JsonData data = new JsonData();

        data.recipes = _recipes;
        data.skills = _skill;
        data.point = _point;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void SaveRecipe(List<RecipeDatas.RecipeInfo> _recipes)
    {
        Debug.Log(Application.persistentDataPath);
        JsonData data = new JsonData();

        data = LoadData();
        data.recipes = _recipes;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void SaveSkill(List<SkillManagement.SkillInfo> _skill)
    {
        Debug.Log(Application.persistentDataPath);
        JsonData data = new JsonData();

        data = LoadData();
        data.skills = _skill;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void SavePoint(int _point)
    {
        Debug.Log(Application.persistentDataPath);
        JsonData data = new JsonData();

        data = LoadData();
        data.point = _point;

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
        SaveData(RecipeDatas.Instance.BackUpBone, SkillManagement.Instance.BackUpBone, 0);
        RecipeDatas.Instance.LoadRecipe();
        SkillManagement.Instance.LoadSkill();
        PlayerDataManagement.Instance.LoadPlayerData();
    }
    #endregion
}
