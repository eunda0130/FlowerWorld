using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input2 : MonoBehaviour
{

    public InputField Input1;

    string password="123";
    public Button Button;

    public void LoginButtonClick()
    {
            if (Input1.text == password)
            {
                Debug.Log("�¾ҽ��ϴ�");
            }
            else
            {
            Debug.Log("Ʋ�Ƚ��ϴ�. �ٽ� �Է����ּ���");
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
