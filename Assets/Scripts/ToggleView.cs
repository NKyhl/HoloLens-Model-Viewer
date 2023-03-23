using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleView : MonoBehaviour
{
    public GameObject referenceObject;

    /*
    public void OnMouseDown()
    {
        if (referenceObject.activeSelf == true)
        {
            referenceObject.SetActive(false);
        }
        else
        {
            referenceObject.SetActive(true);
        }

    }
    */
    public void SwapView() 
    {
        if (referenceObject.activeSelf == true)
        {
            referenceObject.SetActive(false);
        }
        else
        {
            referenceObject.SetActive(true);
        }
    }

}
