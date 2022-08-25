using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void NextButton()
    {

    }
    public void SkipButton()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
