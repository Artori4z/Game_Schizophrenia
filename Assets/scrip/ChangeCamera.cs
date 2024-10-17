using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] Vector3 NewPosition;
    [SerializeField] UnityEngine.Camera InGameCamera;
    
    private void OnMouseDown()
    {
        //do animation go black
        InGameCamera.transform.position = NewPosition;
        //go มีแสง
    }
    
}
