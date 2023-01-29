//using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//using static System.Net.Mime.MediaTypeNames;

public class FoxGameManager : MonoBehaviour
{
    public static FoxGameManager gm;
    RayCast rc;

    Sound s1;
    Sound s2;
    Sound s3;
    Sound s4;
    Sound s5;

    public GameObject FoxFox1;
    public GameObject FoxFox2;
    public GameObject FoxFox3;
    public GameObject FoxFox4;
    public GameObject FoxFox5;
    public GameObject btn;

    [SerializeField]
    private TextMeshProUGUI Text5;
    [SerializeField]
    private TextMeshProUGUI Text6;

    private void Awake()
    {
        if (gm == null)
        { gm = this; }
    }

    public enum GameState
    {
        Ready,
        Run,
        GameOver
    }

    public GameState gState;
    public GameObject gameLabel;


    Text gameText;

    public AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        Text6.enabled = false;
        gState = GameState.Ready;
        gameText = gameLabel.GetComponent<Text>();
        StartCoroutine(ReadyToStart());

        s1 = GameObject.Find("Fox_sit1").GetComponent<Sound>();
        s2 = GameObject.Find("Fox_sit2").GetComponent<Sound>();
        s3 = GameObject.Find("Fox_sit3").GetComponent<Sound>();
        s4 = GameObject.Find("Fox_sit4").GetComponent<Sound>();
        s5 = GameObject.Find("Fox_sit5").GetComponent<Sound>();


    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator ReadyToStart()
    {
        btn.gameObject.SetActive(false);
        yield return new WaitForSeconds(3f);
        Text5.enabled = false;
        yield return new WaitForSeconds(1f);
        gameLabel.SetActive(false);

        beforeGame();

        gState = GameState.Run;

    }


    public void beforeGame()
    {
        if (BGMlist.Length > 0)
        {
            BGM = gameObject.AddComponent<AudioSource>();
            StartCoroutine(Play());
        }

    }

    [System.Serializable]
    public struct BgmType
    {
        public string name;
        public AudioClip audio;
    }
    public BgmType[] BGMlist;

    private AudioSource BGM;
    private string Number = "";

    public void PlayBGM(string name)
    {
        if (Number.Equals(name))
            return;

        for (int i = 0; i < BGMlist.Length; i++)
            if (BGMlist[i].name.Equals(name))
            {
                BGM.clip = BGMlist[i].audio;
                BGM.Play();
                Number = name;
            }

    }
    public int a = 1;
    public int b = 1;

    IEnumerator Play()
    {
        gameText = gameLabel.GetComponent<Text>();
        gameText.color = new Color32(0, 0, 0, 225);

        for (int i = 0; i < 5; i++)
        {
            int r = Random.Range(0, 5);
            switch (r)
            {

                case 0:

                    PlayBGM(BGMlist[0].name);
                    s1.MoveChange();
                    a += 1;
                    yield return new WaitForSeconds(1.5f);
                    break;
                case 1:

                    PlayBGM(BGMlist[1].name);
                    s2.MoveChange();
                    a /= 2;
                    yield return new WaitForSeconds(1.5f);
                    break;
                case 2:

                    PlayBGM(BGMlist[2].name);
                    s3.MoveChange();
                    a -= 3;
                    yield return new WaitForSeconds(1.5f);
                    break;
                case 3:

                    PlayBGM(BGMlist[3].name);
                    s4.MoveChange();
                    a *= 5;
                    yield return new WaitForSeconds(1.5f);
                    break;
                case 4:

                    PlayBGM(BGMlist[4].name);
                    s5.MoveChange();
                    a %= 8;
                    yield return new WaitForSeconds(1.5f);
                    break;
            }


        }
        gameLabel.SetActive(false);
        btn.gameObject.SetActive(true);
        Text6.enabled = true ;

    }
    IEnumerator Waita()
    {
        yield return new WaitForSeconds(1f);
    }
}




