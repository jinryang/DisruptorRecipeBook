using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenStory : MonoBehaviour
{
    public void LoadStoryScene()
    {
        SceneManager.LoadScene(this.gameObject.name);
    }
}
