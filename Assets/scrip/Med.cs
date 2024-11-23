using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Med : Main
{
    /*bool count = false;
    public  void OnHitWith(HpBar Hp)
    {
        if (count == true)
            Hp.TakeHeal(this.Hp);
    }*/
    private void OnMouseDown()
    {
        Heal(10);
    }
}
