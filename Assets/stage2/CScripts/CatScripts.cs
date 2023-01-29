using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CatScripts : MonoBehaviour
{
    public Transform Target;
    NavMeshAgent nav;
    BoxCollider boxCollider;
    Rigidbody rigid;
    public float LimitTime = 30;
    public TextMeshProUGUI Timego;
    Destroy ds;
    Animator anim;
    [SerializeField]
    private GameObject player;
    public GameObject readyText;
    public GameObject GoText;

    public UnityEngine.UI.Image Clear2Image;
    public UnityEngine.UI.Image Over2Image;
    public UnityEngine.UI.Image NEXT2Image;
    public UnityEngine.UI.Image Retry2Image;

    private bool IsClear2 = false;
    private bool Retry2 = false;
    [SerializeField]
    private GameObject cat;
    // Start is called before the first frame update
    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        rigid = GetComponent<Rigidbody>();
    }

    void Start()
    {
        readyText.SetActive(true);
        GoText.SetActive(false);
        Clear2Image.enabled = false;
        Over2Image.enabled = false;
        NEXT2Image.enabled = false;
        Retry2Image.enabled = false;
        boxCollider = GetComponent<BoxCollider>();
        anim = transform.GetComponent<Animator>();
        ds = GameObject.Find("Player_TPS").GetComponent<Destroy>();
        StartCoroutine(Texting());
    }

    // Update is called once per frame
    void Update()
    {
        Timego.text= "시간 : " + Mathf.Round(LimitTime);
        if (LimitTime > 0&& ds.Alive == true)
        {
            StartCoroutine(Runnning());
            anim.SetTrigger("StartToRun");
            nav.SetDestination(Target.position);
        }
        else
        {
            Timego.text = "시간 : 0";
            player.gameObject.SetActive(false);

            if(ds.Alive == true)
            {
                Clear2Image.enabled = true;
                NEXT2Image.enabled = true;
                IsClear2 = true;
                if (Input.GetKeyDown(KeyCode.Space) && IsClear2 == true)
                {
                    SceneManager.LoadScene("Stage2Story2");
                }
            }
            else
            {
                Over2Image.enabled = true;
                Retry2Image.enabled = true;
                Retry2 = true;
                 if (Input.GetKeyDown(KeyCode.R) && IsClear2 == false)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
    }

    IEnumerator Runnning()
    {
        nav.isStopped = true;
        yield return new WaitForSeconds(3f);
        nav.isStopped = false;

        LimitTime -= Time.deltaTime;
    }
    IEnumerator Texting()
    {
        readyText.SetActive(true);
        yield return new WaitForSeconds(3f);
        readyText.SetActive(false);
        GoText.SetActive(true);
        yield return new WaitForSeconds(1f);
        GoText.SetActive(false);
    }

    void FreezeVelocity()
    {
       rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
        
    }
    void FixedUpdate()
    {
        FreezeVelocity();
    }
}
