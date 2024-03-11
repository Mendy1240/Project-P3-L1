using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 startTextSize;
    public void Start()
    {
        startTextSize = transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale *= 1.3f;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = startTextSize;
    }
}

