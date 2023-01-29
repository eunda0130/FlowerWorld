using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public void OnClickStartBtn()
    {
        Debug.Log("Clicked start btn");
    }

    public void OnClickStoryBtn()
    {
        Debug.Log("Clicked story btn");
    }
    public void OnClickExitBtn()
    {
        Debug.Log("Clicked exit btn");
    }
}
