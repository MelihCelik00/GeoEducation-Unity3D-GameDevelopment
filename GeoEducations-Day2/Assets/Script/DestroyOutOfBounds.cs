using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    [SerializeField] private float maxLimit;
    [SerializeField] private float minLimit;
    
    private void Update()
    {
        if (transform.position.z>maxLimit)
        {
            Destroy(this.gameObject);
        }
        else if (transform.position.z < minLimit)
        {
            Destroy(this.gameObject);
        }
    }
}
