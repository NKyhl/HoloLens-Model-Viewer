using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToggleScale : MonoBehaviour
{
    public GameObject referenceObject;
    private bool scaledUp = false;

    public void SwapScale()
    {
        if (referenceObject.activeSelf == false)
            return;

        if (scaledUp == false)
        {
            referenceObject.transform.localScale = referenceObject.transform.localScale * 2;
            scaledUp = true;
        }
        else
        {
            referenceObject.transform.localScale = referenceObject.transform.localScale / 2;
            scaledUp = false;
        }
    }

}
