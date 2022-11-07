using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WallHealth : MonoBehaviour
{
    public int health = 100;

    public TMP_Text Text;

    public GameObject DamageModel;

    private MeshRenderer _meshRenderer;

    private MeshCollider _meshCollider;
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshCollider = GetComponent<MeshCollider>();
    }

    public void Damage(int damage)
    {
        if (health > 0)
        {
            health -= damage; 
        }
        else
        {
            return;
        }
        
    }
    // Update is called once per frame
    private bool spawn;
    void Update()
    {
        Text.text = health.ToString();
        if (health <= 0 && spawn == false)
        {
            _meshRenderer.enabled = false;
            _meshCollider.enabled = false;
            Instantiate(DamageModel, gameObject.transform.position, gameObject.transform.rotation);
            spawn = true;
        }
    }
}
