using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController_TPS : MonoBehaviour
{

    private Animator _animator;

    [SerializeField]
    private float WalkSpeed;

    [SerializeField]
    private float lookSensitivity;


    [SerializeField]
    private Rigidbody myRigid;

    [SerializeField]
    private float jumpForce;

    private bool isGround = true;

    private CapsuleCollider capsuleCollider;

    public bool IsWalk = false;

    // Start is called before the first frame update
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        myRigid = GetComponent<Rigidbody>();
        _animator= GetComponentInChildren<Animator>();
        
    }



    // Update is called once per frame
    void Update()
    {
        IsGround();
        TryJump();
        Move();



    }
    

    private void Move()
    {
        float moveDirX = Input.GetAxisRaw("Horizontal");
        float moveDirZ = Input.GetAxisRaw("Vertical");
        
        Vector3 moveHorizontal = transform.right * moveDirX;
        Vector3 moveVertical = transform.forward * moveDirZ;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * WalkSpeed;

        myRigid.MovePosition(transform.position + velocity * Time.deltaTime);

        if(moveDirZ >= 0.1f)
        {
            _animator.SetBool("IsWalk", true);
        }

        else if (moveDirZ <= -0.1f)
        {
            _animator.SetBool("IsWalk", true);
        }
        else if (moveDirX >= 0.1f)
        {
            _animator.SetBool("IsWalk", true);
        }
        else if (moveDirX <= -0.1f)
        {
            _animator.SetBool("IsWalk", true);
        }
        else
        {
            _animator.SetBool("IsWalk", false);
        }
    }

    private void CharacterRotation()
    {
        //좌우 캐릭터 회전
        float yRotation = Input.GetAxisRaw("Mouse X");
        Vector3 characterRotationY = new Vector3(0f, yRotation, 0f) * lookSensitivity;
        myRigid.MoveRotation(myRigid.rotation * Quaternion.Euler(characterRotationY));
    }


    private void TryJump()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            Jump();
        }
    }

    private void Jump()
    {
        myRigid.velocity = transform.up * jumpForce;

    }

    private void IsGround()
    {
        isGround = Physics.Raycast(transform.position, Vector3.down, capsuleCollider.bounds.extents.y+0.1f);
    }


}
