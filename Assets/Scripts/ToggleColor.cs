using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToggleColor : MonoBehaviour
{
    public GameObject referenceObject;
    private Renderer _renderer;

    private void Start()
    {
        _renderer = referenceObject.GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        if (referenceObject.activeSelf == false)
            return;

        _renderer.material.color =
            _renderer.material.color == Color.red ? Color.blue : Color.red;
    }

}
