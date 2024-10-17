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
    [SerializeField]private float ghostSpawnTime;
    protected int random;
    //spawn ghost 1 per 10 sec
    private void FixedUpdate()
    {
        ghostSpawnTime += Time.deltaTime;
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
