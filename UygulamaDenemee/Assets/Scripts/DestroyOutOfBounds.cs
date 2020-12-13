using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topLimitBoundary = 15;
    [SerializeField] private float lowLimitBoundary = -10;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topLimitBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowLimitBoundary )
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
