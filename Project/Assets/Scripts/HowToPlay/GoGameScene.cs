using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoGameScene : MonoBehaviour
{
    public void GameStart()
    {
        MinigameManagement.Instance.GoGame();
    }
}
