using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI CheeseAfter;

    public static bool IsClear = false;

    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
            Destroy(CheeseAfter);
            IsClear = true;
        }
    }

}
