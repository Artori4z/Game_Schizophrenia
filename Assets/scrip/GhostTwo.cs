using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GhostTwo : GhostAi
{
    [SerializeField] Transform[] playerPosition;
    protected override void GhostMove()
    {
        
        if (random <= difficult)
        {
            //if เดิน ไฟดับ
            ghostTwoD.transform.position = ghostSpawnPoint[0].position;
            
        }
    }
    public void CheackPlayerPo()
    {
        if (player.transform.position == playerPosition[0].transform.position
            &&ghostTwoD.transform.position == ghostSpawnPoint[0].transform.position )
        {
            TakeDamage(Time.deltaTime);
        }
        if (player.transform.position == playerPosition[1].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[1].transform.position)
        {
            TakeDamage(Time.deltaTime);
        }
        if (player.transform.position == playerPosition[2].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[2].transform.position)
        {
            TakeDamage(Time.deltaTime);
        }
        if (player.transform.position == playerPosition[3].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[3].transform.position)
        {
            TakeDamage(Time.deltaTime);
        }
        if (player.transform.position == playerPosition[4].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[4].transform.position)
        {
            TakeDamage(Time.deltaTime);
        }
        if (player.transform.position == playerPosition[5].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[5].transform.position)
        {
            TakeDamage(Time.deltaTime);
        }
        if (player.transform.position == playerPosition[6].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[6].transform.position)
        {
            TakeDamage(Time.deltaTime);
        }
    }
}
