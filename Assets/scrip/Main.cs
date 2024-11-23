using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Main : MonoBehaviour
{
    [SerializeField] MainHp HpRight;
    [SerializeField] MainHp HpLeft;
    float _hp;
    // Start is called before the first frame update
    void Awake()
    {
        _hp = 50;
        HpRight.SetMaxHP(_hp);
        HpLeft.SetMaxHP(_hp);
    }
    public void SetHp(float hp)
    {
        _hp = hp;
        HpRight.UpdateHealthBar(_hp);
        HpLeft.UpdateHealthBar(_hp);
    }
    public void TakeDamage(float damage)
    {
        _hp -= damage;
        HpRight.UpdateHealthBar(_hp);
        HpLeft.UpdateHealthBar(_hp);
    }
    public void Heal(float heal) 
    {
        _hp += heal;
        HpRight.UpdateHealthBar(_hp);
        HpLeft.UpdateHealthBar(_hp);
    }
    public bool IsDead() 
    {
        if (HpRight.ReturnHp() <= 0)
        {
            return true;
        }
        else 
        {
            return false; 
        }
    }
}
