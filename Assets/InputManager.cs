using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;
public class InputManager : MonoBehaviour
{
    private ShellSpawner _shellSpawner;
    // Start is called before the first frame update
    void Start()
    {
        _shellSpawner = gameObject.GetComponent<ShellSpawner>();
        
    }

    // Update is called once per frame
    void Update()
    {
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
