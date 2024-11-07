using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCam : MonoBehaviour
{
    [SerializeField] Camera CloseCamara;
    [SerializeField] Camera OpenCamara;

    private void OnMouseDown()
    {
        if (CloseCamara != null && OpenCamara != null)
        {
            CloseCamara.gameObject.SetActive(false); // ปิด Camera1
            OpenCamara.gameObject.SetActive(true);  // เปิด Camera2
        }
    }
}
