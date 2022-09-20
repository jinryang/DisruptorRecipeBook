using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameManagement : MonoBehaviour
{
    #region Singleton
    private static MinigameManagement instance;
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
    public static MinigameManagement Instance
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

    public int[] moveScenes;
    public int[] points;
    public int idx = 0;
    
    public void PlusScore(int value)
    {
        points[idx - 1] += value;
    }

    public void SetScore(int value)
    {
        points[idx - 1] = value;
    }

    public void SelectRecipe(int number)
    {
        moveScenes = RecipeDatas.Instance.Recipes[number].moveScene;
        points = new int[moveScenes.Length];
        idx = 0;
    }

    public void GoTutorial()
    {
        ChackFinal();
        switch (moveScenes[idx])
        {
            case 1:
            case 2:
            case 3:
                {
                    SceneManager.LoadScene("GubGiPenHow");
                    break;
                }
            case 4:
                {
                    SceneManager.LoadScene("OvenSceneHow");
                    break;
                }
            case 5:
            case 6:
                {
                    SceneManager.LoadScene("BoilHow");
                    break;
                }
            case 7:
            case 8:
            case 9:
                {
                    SceneManager.LoadScene("SprinkleHow");
                    break;
                }
            case 10:
                {
                    SceneManager.LoadScene("CutSceneHow");
                    break;
                }
            case 11:
            case 12:
                {
                    SceneManager.LoadScene("OilFriHow");
                    break;
                }
            case 13:
                {
                    SceneManager.LoadScene("FriHow");
                    break;
                }
            case 14:
                {
                    SceneManager.LoadScene("StackHow");
                    break;
                }
            case 15:
            case 16:
                {
                    Debug.Log("GGulIGiHow");
                    break;
                }
        }
    }
    public void GoGame()
    {
        switch (moveScenes[idx++])
        {
            case 1: { SceneManager.LoadScene("GubGiPenB"); break; }
            case 2: { SceneManager.LoadScene("GubGiPenN"); break; }
            case 3: { SceneManager.LoadScene("GubGiPenS"); break; }
            case 4: { SceneManager.LoadScene("OvenB"); break; }
            case 5: { SceneManager.LoadScene("BoilG"); break; }
            case 6: { SceneManager.LoadScene("BoilT"); break; }
            case 7: { SceneManager.LoadScene("SprinkleBS"); break; }
            case 8: { SceneManager.LoadScene("SprinkleFL"); break; }
            case 9: { SceneManager.LoadScene("SprinkleBL"); break; }
            case 10: { SceneManager.LoadScene("CutN"); break; }
            case 11: { SceneManager.LoadScene("OilFriN"); break; }
            case 12: { SceneManager.LoadScene("OilFriF"); break; }
            case 13: { SceneManager.LoadScene("FriG"); break; }
            case 14: { SceneManager.LoadScene("Stack"); break; }
            case 15: { Debug.Log("GGulIGiT"); break; }
            case 16: { Debug.Log("GGulIGiG"); break; }
        }
    }
    public void ChackFinal()
    {
        if (idx >= moveScenes.Length)
        {
            SceneManager.LoadScene("ScoreCalculation");
        }
    }
}
