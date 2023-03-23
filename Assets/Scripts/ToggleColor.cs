using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ToggleColor : MonoBehaviour
{
    public GameObject referenceObject;
    public Material Material1;
    public Material Material2;

    private Renderer _renderer;
    private bool toggle = true;

    private void Start()
    {
        _renderer = referenceObject.GetComponent<Renderer>();
    }

    public void SwapColor()
    {
        //if (referenceObject.activeSelf == false)
        //    return;

        if (toggle)
        {
            referenceObject.GetComponent<Renderer>().material = Material2;
            toggle = false;
        }
        else 
        {
            referenceObject.GetComponent<Renderer>().material = Material1;
            toggle = true;
        }

        /*
        _renderer.material.color =
            _renderer.material.color == Color.red ? Color.blue : Color.red;
        */
    }

}
