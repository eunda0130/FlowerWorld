using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    [SerializeField]
    private GameController gameController;

    private float moveWidth = 1.5f; //1ȸ �̵� �� �̵� �Ÿ�
    private float moveTimeX = 0.1f; //1ȸ �̵��� �ҿ�Ǵ� �ð�
    private bool isXMove = false; // true: �̵� ��, false: �̵� ����

    [SerializeField]
    private float moveSpeed = 2.0f;

    private Rigidbody rigidbody;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {

        if (gameController.IsGameStart == false) return;

        if (GameController.coinCount > 99)
        {
            
        }
        else if(PlayerCollision.tagCount<3)
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }

    }

    public void MoveToX(int x)
    {
        if (isXMove == true) return;

        if (x > 0 && transform.position.x < moveWidth)
        {
            StartCoroutine(OnMoveToX(x));
        }
        else if (x < 0 && transform.position.x > -moveWidth)
        {
            StartCoroutine(OnMoveToX(x));
        }
    }

    private IEnumerator OnMoveToX(int direction)
    {
        float current = 0;
        float percent = 0;
        float start = transform.position.x;
        float end = transform.position.x + direction * moveWidth;

        isXMove = true;

        while( percent < 1)
        {
            current += Time.deltaTime;
            percent = current / moveTimeX;

            float x = Mathf.Lerp(start, end, percent);
            transform.position = new Vector3(x, transform.position.y, transform.position.z);

            yield return null;
        }

        isXMove = false;
    }
}
