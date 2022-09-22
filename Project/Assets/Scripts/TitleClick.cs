using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleClick : MonoBehaviour
{

    public void MainGo()
    {
        SceneManager.LoadScene("MainScene");
    }
}
