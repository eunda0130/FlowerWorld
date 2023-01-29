using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class InputStage6 : MonoBehaviour
{
    public TMP_InputField Input1;

    private int QuizCount = 0;

    string answer1 = "사과나무";
    string answer2 = "할미꽃";
    string answer3 = "민들레";
    string answer4 = "소나무";
    string answer5 = "진달래";

    [SerializeField] private Image Quiz1;
    [SerializeField] private Image Quiz2;
    [SerializeField] private Image Quiz3;
    [SerializeField] private Image Quiz4;
    [SerializeField] private Image Quiz5;
    [SerializeField] private Image Clear6;
    [SerializeField] private Image Next6;

    [SerializeField] private TextMeshProUGUI RetryT;
    [SerializeField] private TextMeshProUGUI CorrectT;

    public Button Button1;


    public void LoginButtonClick()
    {
        if (QuizCount == 0)
        {
            if (Input1.text == answer1)
            {
                Quiz1.enabled = false;
                Quiz2.enabled = true;
                StartCoroutine(Correct());
                QuizCount++;
            }
            else
            {
                StartCoroutine(Retry());
            }
            Input1.text="";
        }
        else if (QuizCount == 1)
        {
            if (Input1.text == answer2)
            {
                Quiz2.enabled = false;
                Quiz3.enabled = true;
                StartCoroutine(Correct());
                QuizCount++;
            }
            else
            {
                StartCoroutine(Retry());
            }
            Input1.text = "";
        }
        else if (QuizCount == 2)
        {
            if (Input1.text == answer3)
            {
                Quiz3.enabled = false;
                Quiz4.enabled = true;
                StartCoroutine(Correct());
                QuizCount++;
            }
            else
            {
                StartCoroutine(Retry());
            }
            Input1.text = "";
        }
        else if (QuizCount == 3)
        {
            if (Input1.text == answer4)
            {
                Quiz4.enabled = false;
                Quiz5.enabled = true;
                StartCoroutine(Correct());
                QuizCount++;
            }
            else
            {
                StartCoroutine(Retry());
            }
            Input1.text = "";
        }
        else if (QuizCount == 4)
        {
            if (Input1.text == answer5)
            {
                Quiz5.enabled = false;
                Clear6.enabled = true;
                Next6.enabled = true;
                Button1.enabled = false;
                Input1.enabled = false;
                QuizCount++;
            }
            else
            {
                StartCoroutine(Retry());
            }
            Input1.text = "";
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Quiz1.enabled = true;
        Quiz2.enabled = false;
        Quiz3.enabled = false;
        Quiz4.enabled = false;
        Quiz5.enabled = false;
        RetryT.enabled = false;
        CorrectT.enabled = false;
        Clear6.enabled = false;
        Next6.enabled = false;
    }


    IEnumerator Retry()
    {
        RetryT.enabled = true;
        yield return new WaitForSeconds(3f);
        RetryT.enabled = false;
    }
    IEnumerator Correct()
    {
        CorrectT.enabled = true;
        yield return new WaitForSeconds(3f);
        CorrectT.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (QuizCount==5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Ending");
            }
        }
    }
}