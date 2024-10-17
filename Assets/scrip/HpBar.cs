using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpBar : MonoBehaviour
{
    [SerializeField] public Slider HpSlider;
    [SerializeField] public GameObject Ghost;
    protected float Hp;
    protected float MaxHp = 120f;

    void Start()
    {
        Hp = MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (HpSlider.value != Hp)
        {
            HpSlider.value = Hp;
        }
        //overtime -hp
        Hp -= Time.deltaTime;
        //กดผี -5 hp
        //if()
        //กดยา +10 HP

    }
    /*public void TakeDamage(float damage)
    {
        *//*if () { }*//*
    }*/

}
