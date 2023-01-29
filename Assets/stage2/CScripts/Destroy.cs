using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    TextControl tc;
    CatScripts  cat;
    public  bool Alive;
    // Start is called before the first frame update
    void Start()
    {
        tc = GameObject.Find("Canvas").GetComponent<TextControl>();
        cat = GameObject.Find("Cat").GetComponent<CatScripts>();
        Alive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cat")
        {
            tc.ShowGameOver();
            
            Alive = false;

        }
            

    }
}
