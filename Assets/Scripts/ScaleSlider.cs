using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class ScaleSlider : MonoBehaviour
{
    public GameObject referenceObject;
    public GameObject slider;
    private float value;
    private Vector3 baseline;

    private void Start() 
    {
        baseline = referenceObject.transform.localScale;
    }

    public void UpdateScale()
    {
        if (referenceObject.activeSelf == false)
            return;
        
        value = slider.GetComponent<PinchSlider>().SliderValue * 2;
        if (value > 0.05)
            referenceObject.transform.localScale = baseline * value;

        Debug.Log(referenceObject.transform.localScale);

    }

    public void ResetScale() 
    {
        referenceObject.transform.localScale = baseline;
    }

}