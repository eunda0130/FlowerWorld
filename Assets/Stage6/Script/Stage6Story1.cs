using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sage6Story1 : MonoBehaviour
{
    private Vector3 target = new Vector3(-0.308999985f, 0.578999996f, -6.82000017f);

    private int Count = 0;

    [SerializeField]
    private GameObject FineApple;

    [SerializeField] private Image se1;
    [SerializeField] private Image se2;
    [SerializeField] private Image se3;
    [SerializeField] private Image se4;
    [SerializeField] private Image se5;
    [SerializeField] private Image se6;
    [SerializeField] private Image se7;
    [SerializeField] private Image se8;
    [SerializeField] private Image HowTo6;


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
        HowTo6.enabled= false;
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
            FineApple.transform.position = Vector3.MoveTowards(FineApple.transform.position, target, 0.07f);
        }
        else if (Count == 5)
        {
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
            se8.enabled = false;
            HowTo6.enabled = true;
        }
        else if(Count==9)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Stage6");
            }
        }
    }
}
