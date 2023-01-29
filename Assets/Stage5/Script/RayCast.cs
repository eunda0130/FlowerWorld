using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Diagnostics.SymbolStore;
using UnityEngine.SceneManagement;
using TMPro;
//using System.Diagnostics;

public class RayCast : MonoBehaviour
{
    FoxGameManager gm;
    public GameObject gameLabel;
    
    public GameObject GameOver5;
    public GameObject GameClear5;
    public GameObject NEXT5;
    public GameObject Retry5;
    [SerializeField]
    private TextMeshProUGUI Text6;

    public Button btn;

    public bool Over5 = false;
    public bool Clear5= false;



    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<FoxGameManager>();
        GameOver5.SetActive(false);
        GameClear5.SetActive(false);
        NEXT5.SetActive(false);
        Retry5.SetActive(false);
    }

    public void Push()
    {
        gameLabel.SetActive(true);
        if (gm.a == gm.b)
        {
            Text6.enabled = false;
            btn.gameObject.SetActive(false);
            GameClear5.SetActive(true);
            NEXT5.SetActive(true);
            StartCoroutine(Waita());
            Clear5 = true;
        }
        else
        {
            Text6.enabled = false;
            btn.gameObject.SetActive(false);
            StartCoroutine(Waita());
            GameOver5.SetActive(true);
            Retry5.SetActive(true);
            Over5 = true;
        }
        StartCoroutine(Waita());
    }
    IEnumerator Waita()
    {
        yield return new WaitForSeconds(1f);
    }

    private void Update()
    {

        if(Clear5==true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Stage6Story1");
            }
        }
        else if (Over5==true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); ; //æ¿¿¸»Ø
            }
        }
        else
        {

        }
    }
}
