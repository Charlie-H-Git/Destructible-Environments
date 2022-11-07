using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyedController : MonoBehaviour
{
    private BoxCollider _boxCollider;
    public Transform DamageModelParent;

    public int childCount;
    
    public float TotalMass;
    // Start is called before the first frame update
    private void OnEnable()
    {
        _boxCollider = GetComponent<BoxCollider>();
        childCount = DamageModelParent.childCount;
        float DividedMass = TotalMass / childCount;
        foreach (Transform child in DamageModelParent)
        {
            var rb = child.gameObject.GetComponent<Rigidbody>();
            rb.mass = DividedMass;
            print(rb.mass);
        }
    }

    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
