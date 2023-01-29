using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneMove : MonoBehaviour
{
    public void GameScenesCtrl()
    {
        SceneManager.LoadScene("Stage1Story"); // 어떤 씬으로 이동할건지
    }

   
}
