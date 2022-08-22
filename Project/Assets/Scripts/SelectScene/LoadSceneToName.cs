using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneToName : MonoBehaviour
{
    public void Clicked()
    {
        SceneManager.LoadScene(this.gameObject.name);
    }
}
