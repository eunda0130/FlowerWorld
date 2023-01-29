using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Stage2Story1 : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    private int Count = 0;

    [SerializeField] private UnityEngine.UI.Image se1;
    [SerializeField] private UnityEngine.UI.Image se2;
    [SerializeField] private UnityEngine.UI.Image se3;
    [SerializeField] private UnityEngine.UI.Image se4;
    [SerializeField] private UnityEngine.UI.Image se5;
    [SerializeField] private UnityEngine.UI.Image Howto2;

    // Start is called before the first frame update
    void Start()
    {
        se1.enabled = true;
        se2.enabled = false;
        se3.enabled = false;
        se4.enabled = false;
        se5.enabled = false;
        Camera1.enabled = true;
        Camera2.enabled = false;
        Howto2.enabled = false;
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
            Camera1.enabled = false;
            Camera2.enabled = true;
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
            Howto2.enabled = true;
        }
        else if(Count==6)
        {
            SceneManager.LoadScene("Stage2");
        }
    }
}
