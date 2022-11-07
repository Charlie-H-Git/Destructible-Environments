using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ShellSpawner : MonoBehaviour
{
    public float Fire1;
    public GameObject Shell;
    public GameObject FirePosition;
    private void Update()
    {
        if (Fire1 != 0)
        {
            Instantiate(Shell, FirePosition.transform.position, FirePosition.transform.rotation);
        }
    }
}
