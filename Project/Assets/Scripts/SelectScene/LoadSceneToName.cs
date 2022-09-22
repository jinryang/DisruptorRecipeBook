using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneToName : MonoBehaviour
{
    public GameObject cover;
    public void Clicked()
    {
        SceneManager.LoadScene(this.gameObject.name);
    }

    public void SkillClosed()
    {
        cover.SetActive(false);
    }

    public void DestroyPopUp()
    {
        Destroy(this.transform.parent.gameObject);
    }
}
