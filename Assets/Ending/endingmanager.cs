using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class endingmanager : MonoBehaviour
{
    public Image Blackboard1;
    public Image EndingDraw;
    public Image Blackboard2;
    public TextMeshProUGUI EndStory;
    public TextMeshProUGUI MadeBy;
    // Start is called before the first frame update



    void Start()
    {
        StartCoroutine(EndingCoroutine());
    }

    IEnumerator EndingCoroutine()
    {
        yield return new WaitForSeconds(2f);
        StartCoroutine(FadeinCoroutineText(EndStory));
        yield return new WaitForSeconds(7f);
        StartCoroutine(FadeoutCoroutineText(EndStory));
        StartCoroutine(FadeinCoroutineImage1(EndingDraw));
        yield return new WaitForSeconds(5f);
        StartCoroutine(FadeinCoroutineImage2(Blackboard2));
        yield return new WaitForSeconds(2f);
        StartCoroutine(FadeinCoroutineText(MadeBy));
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("main");
    }


    IEnumerator FadeinCoroutineImage1(Image image1)
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            image1.color = new Color(255, 255, 255, fadeCount);
        }
    }

    IEnumerator FadeinCoroutineImage2(Image image2)
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            image2.color = new Color(0, 0, 0, fadeCount);
        }
    }


    IEnumerator FadeinCoroutineText(TextMeshProUGUI Texts)
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            Texts.color = new Color(255, 255, 255, fadeCount);
        }
    }
    IEnumerator FadeoutCoroutineText(TextMeshProUGUI Texts)
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            Texts.color = new Color(0, 0, 0, fadeCount);
        }
    }


        // Update is called once per frame
        void Update()
        {

        }
    }
