using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public GameObject referenceLight;
    private bool lit = true;

    public void SwapLight()
    {
        if (lit == true)
        {
            referenceLight.GetComponent<Light>().intensity = 0.3f;
            lit = false;
        }
        else
        {
            referenceLight.GetComponent<Light>().intensity = 1.0f;
            lit = true;
        }
    }

}
