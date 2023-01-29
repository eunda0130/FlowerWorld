using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Stage5Story1 : MonoBehaviour
{
    [SerializeField]
    private Camera camera1;
    [SerializeField]
    private Camera camera2;
    [SerializeField]
    private Camera camera3;

    private int Count = 0;

    [SerializeField] private Image se1;
    [SerializeField] private Image se2;
    [SerializeField] private Image se3;
    [SerializeField] private Image se4;
    [SerializeField] private Image se5;
    [SerializeField] private Image se6;
    [SerializeField] private Image se7;
    [SerializeField] private Image se8;
    [SerializeField] private Image se9;
    [SerializeField] private Image se10;
    [SerializeField] private Image Howto5;

    // Start is called before the first frame update
    void Start()
    {
        se1.enabled = true;
        se2.enabled = false;
        se3.enabled = false;
        se4.enabled = false;
        Howto5.enabled = false;
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
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
            print(Count);
        }
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
            camera1.enabled = false;
            camera2.enabled= true;
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
            camera2.enabled = false;
            camera3.enabled = true;
            se5.enabled = false;
            se6.enabled = true;
        }
        else if(Count==6)
        {
            se6.enabled= false;
            se7.enabled = true;
        }
        else if (Count == 7)
        {
            se7.enabled= false;
            se8.enabled= true; 
        }
        else if (Count == 8)
        {
            se8.enabled= false;
            se9.enabled= true;
        }
        else if (Count == 9)
        {
            se9.enabled= false;
            Howto5.enabled = true;
        }
        else if (Count == 10)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Stage5");
            }
        }

    }
}

