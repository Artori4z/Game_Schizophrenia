using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ghostsiri : GhostAi
{
    private int _count = 0;
    private Quaternion _rotation;
    private int randomPosition;
    private int positionNow;
    protected override void GhostMove()
    {
       if (random <= difficult)
        {
            //spawn
            if (ghostTwoD.transform.position == startPosition.position) 
            {
                //randomPosition = Random.Range(1,6);
                ghostPosition(1);
                //positionNow = 1;
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
        Debug.Log(_count);
    }
}
