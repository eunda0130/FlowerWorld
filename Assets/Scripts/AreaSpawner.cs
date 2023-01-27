using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AreaSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] areaPrefebs;
    [SerializeField]
    private int spawnAreaCountAtStart = 3;
    [SerializeField]
    private float zDistance = 20;
    private int areaIndex = 0;

    [SerializeField]
    private Transform playerTransform;

    private void Awake()
    {
        for(int i =0; i < spawnAreaCountAtStart; ++i)
        {
            if(i==0)
            {
                SpawnArea(false);
            }
            else
            {
                SpawnArea();
            }
        }
    }

    public void SpawnArea(bool isRandom = true)
    {
        GameObject clone = null;

        if (isRandom == false)
        {
            clone = Instantiate(areaPrefebs[0]);
        }
        else
        {
            int index = Random.Range(0, areaPrefebs.Length);
            clone = Instantiate(areaPrefebs[index]);
        }
        clone.transform.position = new Vector3(0, 0, areaIndex * zDistance);

        clone.GetComponent<Area>().Setup(this, playerTransform);

        areaIndex++;

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
