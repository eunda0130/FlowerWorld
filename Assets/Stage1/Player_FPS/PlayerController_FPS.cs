using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController_FPS : MonoBehaviour
{
    private Animator _animator;


    [SerializeField]
    private float WalkSpeed;

    [SerializeField]
    private float lookSensitivity;

    [SerializeField]
    private float cameraRotationLimit;
    private float currentCameraRotationX = 0f;

    [SerializeField]
    private Camera theCamera;
    private Rigidbody myRigid;

    [SerializeField]
    private float jumpForce;

    private bool isGround = true;

    private BoxCollider boxCollider;

    public bool IsWalk = false;

    public UnityEngine.UI.Image Clear1;
    public UnityEngine.UI.Image Next1;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        myRigid = GetComponent<Rigidbody>();
        _animator = GetComponentInChildren<Animator>();
        Clear1.enabled = false;
        Next1.enabled = false;
    }



    // Update is called once per frame
    void Update()
    {
        if (Portal.IsClear)
        {
            Clear1.enabled = true;
            Next1.enabled = true;
            //씬 변경
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Stage1Story2");
            }
        }
        else
        {
            IsGround();
            TryJump();
            Move();
            CameraRotation();
            CharacterRotation();
        }
    }
    

    private void Move()
    {
        float moveDirX = Input.GetAxisRaw("Horizontal");
        float moveDirZ = Input.GetAxisRaw("Vertical");
        
        Vector3 moveHorizontal = transform.right * moveDirX;
        Vector3 moveVertical = transform.forward * moveDirZ;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * WalkSpeed;

        myRigid.MovePosition(transform.position + velocity * Time.deltaTime);

        if (moveDirZ >= 0.1f)
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

    private void CameraRotation()
    {
        //상하 카메라 회전
        float xRotation = Input.GetAxisRaw("Mouse Y");
        float cameraRotationX = xRotation * lookSensitivity;
        currentCameraRotationX -= cameraRotationX;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);

        theCamera.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
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
        isGround = Physics.Raycast(transform.position, Vector3.down, boxCollider.bounds.extents.y+0.1f);
    }


}
