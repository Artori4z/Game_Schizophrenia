using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Med : Main
{
    public Player player;
    public void OnMouseDown()
    {
        player.Heal(5);
    }
}
