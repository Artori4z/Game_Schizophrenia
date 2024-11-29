using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Med : Main
{
    public Player player;
    public float time;
    [SerializeField] Vector3 CanUse;
    [SerializeField] Vector3 CantUse;
    private void Update()
    {
        time += Time.deltaTime;
        if (time >= 30)
        {
            transform.localPosition = CanUse;
            time = 0;
        }
    }
    public void OnMouseDown()
    {
        player.Heal(15);
        transform.localPosition = CantUse;
    }
}
