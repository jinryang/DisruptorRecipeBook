using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenStory : MonoBehaviour
{
    public bool isHold = true;

    private void Start()
    {
        if (!isHold)
        {
            GetComponent<Image>().color = new Color(158 / 255f, 158 / 255f, 158 / 255f, 1);
        }
    }

    public void LoadStoryScene()
    {
        if (isHold)
        {
            SceneManager.LoadScene(this.gameObject.name);
        }
    }
}
