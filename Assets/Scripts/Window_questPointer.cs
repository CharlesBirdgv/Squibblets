using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_questPointer : MonoBehaviour
{
    private Vector3 targetPosition;
    private RectTransform pointerRectTransform;
    
    private void Awake()
    {
        targetPosition = new Vector3(-9, 14);
        pointerRectTransform = transform.Find("Pointer").GetComponent<RectTransform>();
    }

    private void Update()
    {
        Vector3 toPosition = targetPosition;
        Vector3 fromPosition = Camera.main.transform.position;
        fromPosition.z = 0f;
        Vector3 dir = (toPosition - fromPosition).normalized;
        float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) % 360;
        pointerRectTransform.localEulerAngles = new Vector3(0, 0, angle);
    }
}
