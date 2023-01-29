using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Stage4Story1 : MonoBehaviour
{

    private int Count = 0;

    [SerializeField] private Image se1;
    [SerializeField] private Image se2;
    [SerializeField] private Image se3;
    [SerializeField] private Image se4;
    [SerializeField] private Image Howto4;
    [SerializeField] private Image BG;

    // Start is called before the first frame update
    void Start()
    {
        se1.enabled = true;
        se2.enabled = false;
        se3.enabled = false;
        se4.enabled = false;
        Howto4.enabled = false;
        BG.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        CountSpace();
        SceneStory();
    }

    private void CountSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Count++;
        }
    }

    private void SceneStory()
    {
        if (Count == 1)
        {
            BG.enabled = false;
            se1.enabled = false;
            se2.enabled = true;
        }
        else if (Count == 2)
        {
            se2.enabled = false;
            se3.enabled = true;
        }
        else if (Count == 3)
        {
            se3.enabled = false;
            se4.enabled = true;
        }
        else if (Count == 4)
        {
            se4.enabled = false;
            Howto4.enabled=true;
        }
        else if (Count == 5)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Stage4");
            }
        }
    }
}

