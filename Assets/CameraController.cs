using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 mousePos;
    private CharacterController _characterController;
    public Camera playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, mousePos.x * Time.deltaTime);
        var xRotation = mousePos.y;
        var targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;
        playerCamera.transform.eulerAngles = targetRotation;

        if (Input.GetKey(KeyCode.A))
        {
            _characterController.Move(Vector3.left * 0.05f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _characterController.Move(Vector3.right * 0.05f);
        }
    }
}
