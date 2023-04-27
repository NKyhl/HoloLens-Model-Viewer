using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class ScaleSlider : MonoBehaviour 
{
    // This script controls the functionality of the ScaleSlider, and is applied to the ScaleManipulator helper object under NearMenu
    public GameObject slider;
    public GameObject referenceObject;
    private float value;
    private Vector3 baseline;

    private void Awake() 
    {
        // Set default values
        baseline = referenceObject.transform.localScale;
    }

    public void UpdateScale()
    {
        if (referenceObject.activeSelf == false) return;
        
        value = slider.GetComponent<PinchSlider>().SliderValue * 2;
        if (value > 0.05)
            referenceObject.transform.localScale = baseline * value;
    }

    public void ResetScale() 
    {
        referenceObject.transform.localScale = baseline;
        slider.GetComponent<PinchSlider>().SliderValue = 0.5f;
    }

}