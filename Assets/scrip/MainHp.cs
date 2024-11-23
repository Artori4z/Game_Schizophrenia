using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainHp : MonoBehaviour
{
    [SerializeField] public Slider slider;
    public void SetMaxHP(float maxHealth)
    {
        slider.maxValue = maxHealth;
    }

    public float UpdateHealthBar(float currentHP)
    {
        slider.value = currentHP;
        return slider.value;
    }
    public float ReturnHp()
    {
        return slider.value;
    }
}
