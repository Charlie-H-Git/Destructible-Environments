using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 Target;
    private Vector3 Origin;
    private Rigidbody rb;
    public int ShellDamage;
    public float ExplosionRadius;
    public float ExplosionForce;
    void OnEnable()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = gameObject.transform.forward * 50f ;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destructible"))
        {
            var wallHealth = collision.collider.gameObject.GetComponent<WallHealth>();
            wallHealth.Damage(ShellDamage);
        }

        if (collision.gameObject.CompareTag("WallPeice"))
        {
            var rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.AddExplosionForce(ExplosionForce, collision.gameObject.transform.position, ExplosionRadius, 15f, ForceMode.Impulse);
        }
        
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        List<GameObject> DetectedObjects = new List<GameObject>();
        DetectedObjects.Add(other.gameObject);
        foreach (var gameObject in DetectedObjects)
        {
            if (gameObject.CompareTag("WallPeice"))
            {
                var rb = gameObject.GetComponent<Rigidbody>();
                rb.isKinematic = false;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
