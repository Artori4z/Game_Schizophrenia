using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class HpBar : Main
{
    [SerializeField] public GameObject Ghost;
    [SerializeField] public Camera Player;
    [SerializeField] public Camera Dead;
    void Update()
    {
        if (IsDead())
        {
            SetHp(50);
            if (Dead != null && Player != null)
            {
                Dead.gameObject.SetActive(true); // ปิด Camera1
                Player.gameObject.SetActive(false);  // เปิด Camera2
            }
        }
    }
}
        
        
       
