using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GhostTwo : Main
{
    [SerializeField] Transform[] playerPosition;
    [SerializeField] protected int difficult;
    [SerializeField] protected GameObject ghostTwoD;
    [SerializeField] protected Transform startPosition;
    [SerializeField] protected Transform[] ghostSpawnPoint;
    private float time = 1f;
    [SerializeField] protected Camera player;
    private float ghostSpawnTime = 0;
    protected int difficulty;
    protected int random;
    public Player _player;
    private int randomPosition;
    //spawn ghost 1 per 10 sec
    private void Update()
    {
        difficulty = Random.Range(1, 21);
        ghostSpawnTime += Time.deltaTime;
        if (ghostSpawnTime >= 5 && difficulty <= difficult)
        {
            Debug.Log(difficulty);
            ghostSpawnTime = time;
            GhostMove();
        }
        CheackPlayerPo();
    }
    protected void GhostMove()
    {
        if (random <= difficult)
        {
            //if เดิน ไฟดับ
            randomPosition = Random.Range(1, 6);
            ghostTwoD.transform.position = ghostSpawnPoint[randomPosition].position;
        }
    }
    public void CheackPlayerPo()
    {
        if (player.transform.position == playerPosition[0].transform.position
            &&ghostTwoD.transform.position == ghostSpawnPoint[0].transform.position )
        {
            _player.TakeDamage(Time.deltaTime*5);
        }
        if (player.transform.position == playerPosition[1].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[1].transform.position)
        {
            _player.TakeDamage(Time.deltaTime*5);

        }
        if (player.transform.position == playerPosition[2].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[2].transform.position)
        {
            _player.TakeDamage(Time.deltaTime*5);

        }
        if (player.transform.position == playerPosition[3].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[3].transform.position)
        {
            _player.TakeDamage(Time.deltaTime*5);

        }
        if (player.transform.position == playerPosition[4].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[4].transform.position)
        {
            _player.TakeDamage(Time.deltaTime*5);

        }
        if (player.transform.position == playerPosition[5].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[5].transform.position)
        {
            _player.TakeDamage(Time.deltaTime*5);

        }
        if (player.transform.position == playerPosition[6].transform.position
            && ghostTwoD.transform.position == ghostSpawnPoint[6].transform.position)
        {
            _player.TakeDamage(Time.deltaTime*5);

        }
    }
}
