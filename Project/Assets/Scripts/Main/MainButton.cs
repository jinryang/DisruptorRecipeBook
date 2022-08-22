using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainButton : MonoBehaviour
{
    public GameObject setting;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartButton()
    {
        SceneManager.LoadScene("");
    }
    public void SettingButton()
    {
        setting.SetActive(true);
    }
    public void EndButton()
    {
        Application.Quit();
    }
}
