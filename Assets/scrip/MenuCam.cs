﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCam : MonoBehaviour 
{
    [SerializeField] Camera CloseCamara;
    [SerializeField] Camera OpenCamara;
    [SerializeField] Camera CloseCamara2;
    [SerializeField] Camera CloseCamara3;
    [SerializeField] Camera CloseCamara4;
    [SerializeField] Transform Player;

    private void Start()
    {
        CloseCamara.gameObject.SetActive(true); // ปิด Camera1
        OpenCamara.gameObject.SetActive(false);  // เปิด Camera2
        CloseCamara2.gameObject.SetActive(false);
        CloseCamara3.gameObject.SetActive(false);
        CloseCamara4.gameObject.SetActive(false);

    }
    private void OnMouseDown()
    {
        if (CloseCamara != null && OpenCamara != null)
        {
            CloseCamara.gameObject.SetActive(false); // ปิด Camera1
            OpenCamara.gameObject.SetActive(true);  // เปิด Camera2
            CloseCamara2.gameObject.SetActive(false);
            OpenCamara.transform.position = Player.transform.position;
        }
    }
}
