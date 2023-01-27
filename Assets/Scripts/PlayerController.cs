using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float dragDistance = 50.0f;
    private Vector3 touchStart;
    private Vector3 touchEnd;

    [SerializeField]
    private Image ClearUi;
    [SerializeField]
    private Image FailedUi;
    [SerializeField]
    private Image Life3;
    [SerializeField]
    private Image Life2;
    [SerializeField]
    private Image Life1;
    [SerializeField]
    private Image Life0;

    private Movement movement;

    private void Awake()
    {
        movement = GetComponent<Movement>();
        ClearUi.enabled = false;
        FailedUi.enabled= false;
        Life3.enabled = false;
        Life2.enabled = false;
        Life1.enabled = false;
        Life0.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.coinCount>99)
        {
            ClearUi.enabled = true;
        }
        else if(PlayerCollision.tagCount<3)
        {
            OnPCPlatform();
        }
        else
        {
            Life2.enabled = false;
            Life3.enabled = true;
            FailedUi.enabled = true;
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    GameController.coinCount =0;
                    PlayerCollision.tagCount = 0;
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }

    }

    private void LifeUI()
    {
        if(PlayerCollision.tagCount==0)
        {
            Life0.enabled = true;
        }
        else if (PlayerCollision.tagCount == 1)
        {
            Life0.enabled = false;
            Life1.enabled = true;
        }
        else if (PlayerCollision.tagCount == 2)
        {
            Life1.enabled = false;
            Life2.enabled = true;
        }
    }

    private void OnPCPlatform()
    {
        LifeUI();

        if (Input.GetMouseButtonDown(0))
        {
            touchStart = Input.mousePosition;
        }
        else if(Input.GetMouseButton(0))
        {
            touchEnd = Input.mousePosition;

            OnDragXY();
        }
    }

    private void OnDragXY()
    {
        if(Mathf.Abs(touchEnd.x - touchStart.x)>=dragDistance)
        {
            movement.MoveToX((int)Mathf.Sign(touchEnd.x - touchStart.x));
            return;
        }
    }
}
