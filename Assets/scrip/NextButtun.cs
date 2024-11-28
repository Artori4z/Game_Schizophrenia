using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButtun : MonoBehaviour
{
    [SerializeField] Camera CloseCamara;
    [SerializeField] Camera OpenCamara;
    [SerializeField] Transform[] Player;
    int i = -1;
    private void OnMouseDown()
    {
        if (CloseCamara != null && OpenCamara != null)
        {
            i++;
            CloseCamara.gameObject.SetActive(false); // ปิด Camera1
            OpenCamara.gameObject.SetActive(true);  // เปิด Camera2
            OpenCamara.transform.position = Player[i].transform.position;
        }
    }
}
