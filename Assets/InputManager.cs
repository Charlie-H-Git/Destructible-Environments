using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;
public class InputManager : MonoBehaviour
{
    private ShellSpawner _shellSpawner;

    private CameraController _cameraController;
    // Start is called before the first frame update
    void Start()
    {
        _shellSpawner = gameObject.GetComponent<ShellSpawner>();
        _cameraController = gameObject.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        _cameraController.mousePos = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _shellSpawner.Fire1 = 1;
        }
        else
        {
            _shellSpawner.Fire1 = 0;
        }
        
    }
}
