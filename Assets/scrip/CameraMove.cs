using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] protected float RotationSpeed;
    [SerializeField] protected float xMin;
    [SerializeField] protected float xMax;
    [SerializeField] protected float yMin;
    [SerializeField] protected float yMax;
    protected float yRotation;
    protected float xRotation;
    Vector3 Position;
    Vector3 StartPosition;
    [SerializeField] Transform[] MovePosition;
    [SerializeField] UnityEngine.Camera InGameCamera;
    private void Start()
    {
        Position = transform.position;
        transform.position = Position;
    }
    private void Update()
    {
        if (InGameCamera.transform.position != Position)
        {
            CamPosition(0);
        }
        float UpDown = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
        float LeftRight = Input.GetKey(KeyCode.A) ? 1 : Input.GetKey(KeyCode.D) ? -1 : 0;

        xRotation -= UpDown * RotationSpeed * Time.deltaTime;
        yRotation -= LeftRight * RotationSpeed * Time.deltaTime;

        xRotation = Mathf.Clamp(xRotation, yMin, yMax);
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);    
    }
    public void CamPosition(int i)
    {
        if(transform.position == MovePosition[0].transform.position 
            || transform.position == MovePosition[2].transform.position
            || transform.position == MovePosition[4].transform.position
            || transform.position == MovePosition[6].transform.position
            ){
            i = 1;
        }if (transform.position == MovePosition[1].transform.position
            || transform.position == MovePosition[5].transform.position){
            i = 2;
        }if(transform.position == MovePosition[3].transform.position)
        {
            i= 3;
        }

        switch (i)
        {
            case 1:
                xRotation = 0;
                yRotation = 0;
                Position = transform.position;

                break;
            case 2:
                xRotation = 0;
                yRotation = -90;
                Position = transform.position;

                break;
            case 3:
                xRotation = 0;
                yRotation = 180;
                Position = transform.position;
                break;
        }

    }
}
