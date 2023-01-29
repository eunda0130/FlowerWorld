using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Sound : MonoBehaviour
{
    public GameObject fox;
    public AudioSource aud;

    public AudioClip no;
    FoxGameManager gm;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<FoxGameManager>();
        anim= transform.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (fox == getClickedObject(out RaycastHit hit))
            {
                ClickSound();
                if (fox== GameObject.Find( "Fox_sit1"))
                {
                    gm.b += 1;
                    
                    anim.SetTrigger("SitToAttack");
                    anim.SetTrigger("AttackToSit");

                    print("b=" + gm.b);
                    
                }
                else if (fox == GameObject.Find("Fox_sit2"))
                {
                    gm.b /= 2;
                    
                    anim.SetTrigger("SitToAttack");
                    anim.SetTrigger("AttackToSit");
                    print("b=" + gm.b);
                    
                }
                else if (fox == GameObject.Find("Fox_sit3"))
                {
                    gm.b -= 3;                
                    anim.SetTrigger("SitToAttack");
                    anim.SetTrigger("AttackToSit");
                    print("b=" + gm.b);
                    
                }
                else if (fox == GameObject.Find("Fox_sit4"))
                {
                    gm.b *= 5;
                    
                    anim.SetTrigger("SitToAttack");
                    anim.SetTrigger("AttackToSit");
                    print("b=" + gm.b);
                    
                }
                else if (fox == GameObject.Find("Fox_sit5"))
                {
                    gm.b %= 8;
                    
                    anim.SetTrigger("SitToAttack");
                    anim.SetTrigger("AttackToSit");
                    print("b=" + gm.b);
                    
                }
               
                
            }
           
        }
    }
    public void MoveChange()
    {
        anim.SetTrigger("SitToAttack");
        anim.SetTrigger("AttackToSit");
    }

    public void ClickSound()
    {
        aud.PlayOneShot(no);
    }

    GameObject getClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            if (!isPointerOverUIObject()) { target = hit.collider.gameObject; }
        }
        return target;
    }
    private bool isPointerOverUIObject()
    {
        PointerEventData ped = new PointerEventData(EventSystem.current);
        ped.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        return results.Count > 0;
    }
}

