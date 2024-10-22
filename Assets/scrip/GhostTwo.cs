using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTwo : GhostAi
{
    protected override void GhostMove()
    {
        if (random <= difficult)
        {
            //if เดิน ไฟดับ
            ghostTwoD.transform.position = ghostSpawnPoint[0].position;
        }
    }
}
