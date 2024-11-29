using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : Main
{
    [SerializeField] public Transform GCheack;
    [SerializeField] public Vector3 Spawn;
    [SerializeField] public Vector3 NotSpawn;
    [SerializeField] public GameObject Ghost;
    public Player player;
    public void Update()
    {
        if (Ghost.transform.position == GCheack.transform.position)
        {
            transform.position = Spawn;
        }
        if (transform.position == Spawn) 
        {
            player.TakeDamage(Time.deltaTime / 2);
        }
    }
    protected void OnMouseDown()
    {
        transform.position = NotSpawn;
        player.Heal(5);
    }
}
