using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ghostsiri : GhostAi
{
    private int _index = 1;
    private int _count = 0;
    private Quaternion _rotation;
    private int randomPosition;
    protected override void GhostMove()
    {
       if (random <= difficult)
        {
            //spawn
            if (ghostTwoD.transform.position == startPosition.position) 
            {
                ghostPosition(1);
            }
        }
    }
    //move ghost 4 position
    protected void ghostPosition(int gPosition)
    {
        switch(gPosition)
        {
            case 1:
                _rotation = Quaternion.Euler(0, 0, 180);
                ghostTwoD.transform.rotation = _rotation;
                ghostTwoD.transform.position = ghostSpawnPoint[0].position;
                break;
            case 2:
                _rotation = Quaternion.Euler(0, -70, 180);
                ghostTwoD.transform.rotation = _rotation;
                ghostTwoD.transform.position = ghostSpawnPoint[1].position;
                break;
            case 3:
                _rotation = Quaternion.Euler(0, 80, 180);
                ghostTwoD.transform.rotation = _rotation;
                ghostTwoD.transform.position = ghostSpawnPoint[2].position;
                break;
            case 4:
                _rotation = Quaternion.Euler(0, 0, 180);
                ghostTwoD.transform.rotation = _rotation;
                ghostTwoD.transform.position = ghostSpawnPoint[3].position;
                break;
        }
        
    }
    protected void OnMouseDown()
    {

        /*if (_count == 2)
        {
            ghostTwoD.transform.position = startPosition.position;
        }*/
        //random ghost next position
        randomPosition = Random.Range(1,5);
        ghostPosition(randomPosition);
        
    }
}
