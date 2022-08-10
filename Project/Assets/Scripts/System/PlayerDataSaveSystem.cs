using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;

public class PlayerDataSaveSystem : MonoBehaviour
{
    #region Singleton
    private static PlayerDataSaveSystem instance;
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
    public static PlayerDataSaveSystem Instance
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
        public string userName = "I'm gay";
        public int storyPoint;
        public List<RecipeDatas.RecipeInfo> recipes;
        public SkillManagement skills;
    }

    public void SaveData(List<RecipeDatas.RecipeInfo> _recipes)
    {
        Debug.Log(Application.persistentDataPath);
        JsonData data = new JsonData();

        data.recipes = _recipes;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void SaveName(string _name)
    {
        JsonData data = LoadData();

        data.userName = _name;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void SaveStoryPoint(int _point)
    {
        JsonData data = LoadData();

        data.storyPoint = _point;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void SaveRecipes(List<RecipeDatas.RecipeInfo> _recipes)
    {
        JsonData data = LoadData();

        data.recipes = _recipes;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void SaveSkills(SkillManagement _skill)
    {
        JsonData data = LoadData();

        data.skills = _skill;

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
}
