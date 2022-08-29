using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySelectBackButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BackStoryScene()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
