using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ghostsiri : Main
{
    private int _count = 0;
    private Quaternion _rotation;
    private int randomPosition;
    private int positionNow;
    private float currentHP;
    [SerializeField] protected int difficult;
    protected int difficulty;
    [SerializeField] protected GameObject ghostTwoD;
    [SerializeField] protected Transform startPosition;
    [SerializeField] protected Transform[] ghostSpawnPoint;
    private float time = 1f;
    [SerializeField] protected Camera player;
    private float ghostSpawnTime = 0;
    protected int random;
    private float cantSpawn = 10;
    public Player _Player;
    //spawn ghost 1 per 10 sec
    private void Update()
    {
        difficulty = Random.Range(1, 21);
        ghostSpawnTime += Time.deltaTime;
        if(ghostTwoD.transform.position == startPosition.position)
        {
            cantSpawn += Time.deltaTime;
            Debug.Log(cantSpawn);
        }
        if (ghostSpawnTime >= 5 && difficulty <= difficult && cantSpawn >= 10)
        {
            ghostSpawnTime = time;
            GhostMove();
        }
        if(ghostTwoD.transform.position == ghostSpawnPoint[0].position ||
           ghostTwoD.transform.position == ghostSpawnPoint[1].position ||
           ghostTwoD.transform.position == ghostSpawnPoint[2].position ||
           ghostTwoD.transform.position == ghostSpawnPoint[3].position ||
           ghostTwoD.transform.position == ghostSpawnPoint[4].position ||
           ghostTwoD.transform.position == ghostSpawnPoint[5].position ||
           ghostTwoD.transform.position == ghostSpawnPoint[6].position )
        {
            _Player.TakeDamage(Time.deltaTime);
        }
    }
    protected void GhostMove()
    {
       if (random <= difficult)
        {
            //spawn
            if (ghostTwoD.transform.position == startPosition.position) 
            {
                randomPosition = Random.Range(1,8);
                ghostPosition(randomPosition);
                cantSpawn = 0;
            }
        }
    }
    //move ghost 4 position
    protected void ghostPosition(int gPosition)
    {
        if (_count < 4)
        {
            switch (gPosition)
            {
                case 1:
                    _rotation = Quaternion.Euler(0, 180, 0);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[0].position;

                    break;
                case 2:
                    _rotation = Quaternion.Euler(0, 90, 0);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[1].position;
                    
                    break;
                case 3:
                    _rotation = Quaternion.Euler(0, 130, 0);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[2].position;
                    
                    break;
                case 4:
                    _rotation = Quaternion.Euler(0, 0, 0);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[3].position;
                    
                    break;
                case 5:
                    _rotation = Quaternion.Euler(0, 90, 0);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[4].position; 
                    
                    break;
                case 6:
                    _rotation = Quaternion.Euler(0, 90, 0);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[5].position;
                    break;
                case 7:
                    _rotation = Quaternion.Euler(0, 90, 0);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[6].position;
                    break;
            }
            
        }
        else if (_count >= 4) 
        {
            ghostTwoD.transform.position = startPosition.position;
            _count = 0;
        }
    }
    protected void OnMouseDown()
    {
        _count++;
        //random ghost next position
        randomPosition = Random.Range(1,6);
        ghostPosition(randomPosition);
        
    }
}
