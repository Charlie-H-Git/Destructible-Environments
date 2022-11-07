using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 mousePos;

    public Camera playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, mousePos.x * Time.deltaTime);
        var xRotation = mousePos.y;
        var targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;
        playerCamera.transform.eulerAngles = targetRotation;
    }
}
