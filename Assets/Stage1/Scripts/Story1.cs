using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story1 : MonoBehaviour
{

    private Animator animatorSp;

    public Camera Camera1;
    public Camera Camera2;
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
    [SerializeField] private Image se11;
    [SerializeField] private Image se12;
    [SerializeField] private Image se13;
    [SerializeField] private Image se14;
    [SerializeField] private Image se15;
    [SerializeField] private Image BackGround1;

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
        se12.enabled = false;
        se13.enabled = false;
        se14.enabled = false;
        se15.enabled = false;
        Camera1.enabled = true;
        Camera2.enabled = false;
        animatorSp = GetComponentInChildren<Animator>();
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
            se5.enabled = true;
            BackGround1.enabled= false;
            animatorSp.SetBool("IsAct",true);
        }
        else if (Count == 5)
        {
            se5.enabled = false;
            se6.enabled = true;
            animatorSp.SetBool("IsAct", false);
        }
        else if (Count == 6)
        {
            se6.enabled = false;
            se7.enabled = true;

            Camera1.enabled = false;
            Camera2.enabled = true;
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
            se12.enabled = true;
        }
        else if (Count == 12)
        {
            se12.enabled = false;
            se13.enabled = true;
        }
        else if (Count == 13)
        {
            se13.enabled = false;
            se14.enabled = true;
        }
        else if (Count == 14)
        {
            se14.enabled = false;
            se15.enabled = true;
        }
        else if (Count == 15)
        {
            SceneManager.LoadScene("Stage1");
        }
    }
}
