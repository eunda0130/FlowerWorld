using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour
{
    public static TextControl instance;
    public TextMeshProUGUI readyText;
    public TextMeshProUGUI GoText;
    public UnityEngine.UI.Image Clear2Image;
    public UnityEngine.UI.Image Over2Image;
    public UnityEngine.UI.Image RertyImage;

    CatScripts cs;
    // Start is called before the first frame update
    private void Awake()
    {
        if(TextControl.instance != null)
        {
            TextControl.instance = this;
        }
    }
    void Start()
    {
        cs = GameObject.Find("Cat").GetComponent<CatScripts>();
    }

    public void ShowGameClear()
    {

    }
    public void ShowGameOver()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
