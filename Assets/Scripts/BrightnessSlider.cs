using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class BrightnessSlider : MonoBehaviour
{
    public GameObject referenceLight;
    public GameObject slider;
    private float value;

    public void UpdateLight()
    {
        value = slider.GetComponent<PinchSlider>().SliderValue;
        referenceLight.GetComponent<Light>().intensity = value;
    }
}
