using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textTapToPlay;

    [SerializeField]
    private TextMeshProUGUI textCoinCount;

    public static int coinCount = 0;

    public bool IsGameStart { private set; get; }

    private void Awake()
    {
        IsGameStart = false;
        textTapToPlay.enabled = true;
        textCoinCount.enabled = false;

    }

    private IEnumerator Start()
    {
        while (true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                IsGameStart = true;

                textTapToPlay.enabled = false;
                textCoinCount.enabled = true;

                break;
            }
            yield return null;
        }
    }
 
    public void IncreaseCoinCount()
    {
        coinCount++;
        textCoinCount.text = "Flower : "+coinCount.ToString();
    }

    public void GameOver()
    {
        //if(PlayerCollision.tagCount > 2&&Input.GetKeyDown(KeyCode.R))
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //}
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
