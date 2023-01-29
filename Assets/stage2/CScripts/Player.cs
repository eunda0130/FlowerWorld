using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;
    private bool CanMove=false;

    Vector3 moveVec;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(Wait());
        if (CanMove==true)
        {
            hAxis = Input.GetAxisRaw("Horizontal");
            vAxis = Input.GetAxisRaw("Vertical");

            moveVec = new Vector3(hAxis, 0, vAxis).normalized;

            transform.position += moveVec * speed * Time.deltaTime;
            anim.SetTrigger("IsWalk");

            transform.LookAt(transform.position + moveVec);
        }
        else { }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        CanMove = true;
    }
}
