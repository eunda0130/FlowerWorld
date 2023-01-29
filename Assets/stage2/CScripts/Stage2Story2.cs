using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Stage2Story2 : MonoBehaviour
{
    //public Camera Camera1;
    private int Count = 0;

    [SerializeField] private UnityEngine.UI.Image se1;
    [SerializeField] private UnityEngine.UI.Image se2;
    [SerializeField] private UnityEngine.UI.Image se3;
    [SerializeField] private UnityEngine.UI.Image se4;
    [SerializeField] private UnityEngine.UI.Image se5;
    [SerializeField] private UnityEngine.UI.Image se6;
    [SerializeField] private UnityEngine.UI.Image se7;
    [SerializeField] private UnityEngine.UI.Image se8;
    [SerializeField] private UnityEngine.UI.Image se9;
    [SerializeField] private UnityEngine.UI.Image se10;
    [SerializeField] private UnityEngine.UI.Image se11;
    [SerializeField] private UnityEngine.UI.Image BG;
    [SerializeField] private UnityEngine.UI.Image Howto3;

    // Start is called before the first frame update
    void Start()
    {
        se1.enabled = true;
        se2.enabled = false;
        se3.enabled = false;
        se4.enabled = false;
        se5.enabled = false;
        se6.enabled = false;
        se7.enabled = false;
        se8.enabled = false;
        se9.enabled = false;
        se10.enabled = false;
        se11.enabled = false;   
        BG.enabled = true;
        Howto3.enabled = false;
    }
    private void CountSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Count++;
        }
    }



    // Update is called once per frame
    void Update()
    {
        CountSpace();
        SceneStory();
    }

    private void SceneStory()
    {
        if (Count == 1)
        {
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
            BG.enabled = false;
            se3.enabled = false;
            se4.enabled = true;
        }
        else if (Count == 4)
        {
            se4.enabled = false;
            se5.enabled = true;
        }
        else if (Count == 5)
        {
            se5.enabled = false;
            se6.enabled = true;
        }
        else if (Count == 6)
        {
            se6.enabled = false;
            se7.enabled = true;
        }
        else if (Count == 7)
        {
            se7.enabled = false;
            se8.enabled = true;
        }
        else if (Count == 8)
        {
            se8.enabled = false;
            se9.enabled = true;
        }
        else if (Count == 9)
        {
            se9.enabled = false;
            se10.enabled = true;
        }
        else if (Count == 10)
        {
            se10.enabled = false;
            se11.enabled = true;
        }
        else if (Count == 11)
        {
            se11.enabled = false;
            Howto3.enabled = true;
        }
        else if (Count == 12)
        {
            SceneManager.LoadScene("Stage3");
        }
    }
}
