using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class MainHp : MonoBehaviour
{
    private float maxHp;
    protected float MaxHp { get { return maxHp; } set { maxHp = value; } }
    private float hp;
    protected float Hp { get { return hp; } set { hp = value; } }
    public void TakeHeal(float heal)
    {
        Hp += heal;
    }
}
