using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    private GameController gameController;

    public static int tagCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Obstacle"))
        {
            tagCount++;
        }
        else if(other.tag.Equals("Coin"))
        {
            gameController.IncreaseCoinCount();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
