using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story2 : MonoBehaviour
{
    private Vector3 target = new Vector3(1.5f,0.02f,1.08f);

    private int Count = 0;

    [SerializeField]
    private GameObject Rat;

    [SerializeField] private Image se1;
    [SerializeField] private Image se2;
    [SerializeField] private Image se3;
    [SerializeField] private Image se4;
    [SerializeField] private Image BackGround1;

    // Start is called before the first frame update
    void Start()
    {
        se1.enabled = true;
        se2.enabled = false;
        se3.enabled = false;
        se4.enabled = false;
        BackGround1.enabled = false;
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
            
           Rat.transform.position= Vector3.MoveTowards(Rat.transform.position, target, 0.02f);

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
            BackGround1.enabled = true;
        }

        else if (Count == 4)
        {
            SceneManager.LoadScene("Stage2Story1");
        }
    }
}
