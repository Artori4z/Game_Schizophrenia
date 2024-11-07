using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public abstract class GhostAi : MonoBehaviour
{
    [SerializeField] protected int difficult;
    [SerializeField] protected GameObject ghostTwoD;
    [SerializeField] protected Transform startPosition;
    [SerializeField] protected Transform[] ghostSpawnPoint;
    private float time = 1f;
    [SerializeField] protected Camera player;
    private float ghostSpawnTime = 0;
    protected int random;
    //spawn ghost 1 per 10 sec
    private void FixedUpdate()
    {
        ghostSpawnTime += Time.fixedDeltaTime;
        if (ghostSpawnTime >= 5)
        {
            ghostSpawnTime = time;
            GhostMove();
        }
    }
    protected virtual void GhostMove()
    {
         random = Random.Range (1,21);
        
    }

}
