using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class HpBar : MainHp
{
    [SerializeField] public Slider HpSlider;
    [SerializeField] public GameObject Ghost;
    [SerializeField] public Camera Player;
    [SerializeField] public Camera Dead;
     

    private void Awake()
    {
        MaxHp = 20f;
        Hp = MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        Hp -= Time.deltaTime;

        if (Hp > 0)
        {
            if (HpSlider.value != Hp)
            {
                HpSlider.value = Hp;
            }
        }
        else
        {
            if (Dead != null && Player != null)
            {
                Dead.gameObject.SetActive(true); // ปิด Camera1
                Player.gameObject.SetActive(false);  // เปิด Camera2
            }
        }
        
        //overtime -hp
        //กดผี -5 hp
        //if()
        //กดยา +10 HP
    }
    /*public void TakeDamage(float damage)
    {
        *//*if () { }*//*
    }*/
}
