using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActionController : MonoBehaviour
{

    [SerializeField]
    private float range;
    private bool pickupActivated = false;

    private RaycastHit hitInfo;

    [SerializeField]
    private LayerMask layerMask;

    [SerializeField]
    private TextMeshProUGUI CheeseBefore;

    [SerializeField]
    private TextMeshProUGUI CheeseAfter;

    private bool PickupChs = false;

    public GameObject portal;

    // Start is called before the first frame update
    void Start()
    {
        CheeseAfter.gameObject.SetActive(false);
        portal.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        TryAction();
        CheckItem();
    }

    private void TryAction()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            CheckItem();
            CanPickUp();
        }
    }

    private void CanPickUp()
    {
        if(pickupActivated)
        {
            if(hitInfo.transform !=null)
            {
                Destroy(hitInfo.transform.gameObject);
                PickupChs = true;
                infoDisappear();
                if (PickupChs)
                {
                    CheeseAfter.gameObject.SetActive(true);
                    portal.gameObject.SetActive(true);
                }
            }
        }
    }

    private void CheckItem()
    {
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out hitInfo, range, layerMask))
        {
            if(hitInfo.transform.tag=="Item")
            {
                ItemInfoAppear();
            }
        }
        else
        {
            infoDisappear();
        }
    }

    private void ItemInfoAppear()
    {
        pickupActivated = true;
        CheeseBefore.gameObject.SetActive(true);

    }

    private void infoDisappear()
    {
        pickupActivated= false;
        CheeseBefore.gameObject.SetActive(false);
    }


}
