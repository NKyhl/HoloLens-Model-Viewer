using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class BrightnessSlider : MonoBehaviour
{
    // This script controls the functionality of the BrightnessSlider, and is applied to the BrightnessManipulator helper object under UI -> Main Menu
    public GameObject referenceLight;
    public GameObject slider;
    private float value;
    private float baseline;

    private void Start()
    {
        baseline = referenceLight.GetComponent<Light>().intensity;
    }

    public void UpdateLight()
    {
        value = slider.GetComponent<PinchSlider>().SliderValue;
        referenceLight.GetComponent<Light>().intensity = value;
    }

    public void ResetLight()
    {
        referenceLight.GetComponent<Light>().intensity = baseline;
        slider.GetComponent<PinchSlider>().SliderValue = baseline;
    }
}
