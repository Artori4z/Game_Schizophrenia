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
    private void Update()
    {
        float UpDown = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
        float LeftRight = Input.GetKey(KeyCode.A) ? 1 : Input.GetKey(KeyCode.D) ? -1 : 0;
        xRotation -= UpDown * RotationSpeed * Time.deltaTime;
        yRotation -= LeftRight * RotationSpeed * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, yMin, yMax);
        yRotation = Mathf.Clamp(yRotation, xMin, xMax);
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
