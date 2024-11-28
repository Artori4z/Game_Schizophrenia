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
    [SerializeField] protected GameObject ghostTwoD;
    [SerializeField] protected Transform startPosition;
    [SerializeField] protected Transform[] ghostSpawnPoint;
    private float time = 1f;
    [SerializeField] protected Camera player;
    private float ghostSpawnTime = 0;
    protected int random;
    //spawn ghost 1 per 10 sec
    private void Update()
    {
        ghostSpawnTime += Time.deltaTime;
        if (ghostSpawnTime >= 5)
        {
            ghostSpawnTime = time;
            GhostMove();
        }
    }
    protected  void GhostMove()
    {
       if (random <= difficult)
        {
            //spawn
            if (ghostTwoD.transform.position == startPosition.position) 
            {
                randomPosition = Random.Range(1,6);
                ghostPosition(randomPosition);
                
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
                    _rotation = Quaternion.Euler(90, 0, 180);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[0].position;

                    break;
                case 2:
                    _rotation = Quaternion.Euler(90, 0, 270);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[1].position;
                    
                    break;
                case 3:
                    _rotation = Quaternion.Euler(90, 0, 230);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[2].position;
                    
                    break;
                case 4:
                    _rotation = Quaternion.Euler(90, 0, 0);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[3].position;
                    
                    break;
                case 5:
                    _rotation = Quaternion.Euler(90, 0, 180);
                    ghostTwoD.transform.rotation = _rotation;
                    ghostTwoD.transform.position = ghostSpawnPoint[4].position; 
                    
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
        base.TakeDamage(10);
    }
}
