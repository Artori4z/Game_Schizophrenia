using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Main : MonoBehaviour
{
    [SerializeField] MainHp HpRight;
    [SerializeField] MainHp HpLeft;
    float _hp;
    protected float HP { get { return _hp; } set { _hp = 50; } }
    // Start is called before the first frame update
    void Start()
    {
        SetMaxHp(50);
    }
    public void SetMaxHp(float hp)
    {
        HP = hp;
        HpRight.SetMaxHP(HP);
        HpLeft.SetMaxHP(HP);
    }
    public void SetHp(float hp)
    {
        HP = hp;
        HpRight.UpdateHealthBar(HP);
        HpLeft.UpdateHealthBar(HP);
    }
    public void TakeDamage(float damage)
    {
        Debug.Log(HP);
        HP -= damage;
        HpRight.UpdateHealthBar(HP);
        HpLeft.UpdateHealthBar(HP);
        Debug.Log(HP);
    }
    public void Heal(float heal) 
    {
        if (HP < 50) 
        {
            HP += heal;
            HpRight.UpdateHealthBar(HP);
            HpLeft.UpdateHealthBar(HP);
        }
        
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
