using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeColor : MonoBehaviour, IPointerClickHandler
{
    private MeshRenderer meshRenderer;

    public void OnPointerClick(PointerEventData eventData)
    {
        SetRandomColor();
    }

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    
    private Color RandomColor()
    {
        return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
    }

    private void SetRandomColor()
    {
        meshRenderer.material.color = RandomColor();
    }

    void Update()
    {
        
    }
}
