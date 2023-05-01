using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleView : MonoBehaviour
{
    // This script is used by the HideShow Button under UI -> ButtonCollection -> HideShowButton
    public GameObject referenceObject;
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
