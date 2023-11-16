using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _radius;
    [SerializeField] private bool _switchFlag;
    
    private void Exploed()
    {
        Collider[] arrColliders = Physics.OverlapSphere(transform.position, _radius);
        
        for (int i = 0; i < arrColliders.Length; i++)
        {
            Rigidbody rigidbody = arrColliders[i].attachedRigidbody;
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(_force, transform.position, _radius);
            }
        }
    }

    void Update()
    {
        Invoke("Exploed" ,5f);
    }
}
