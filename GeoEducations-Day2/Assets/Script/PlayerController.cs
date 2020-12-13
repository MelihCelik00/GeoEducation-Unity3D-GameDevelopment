using System;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput; // -1 0 1
    private float speed = 10f;
    [SerializeField] public float xRange = 15f;
    [SerializeField] public GameObject ammoPrefab;
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Move();    
        CheckRange();
        Shoot();
    }

    private void Move()
    {
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    private void CheckRange()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ammoPrefab,transform.position,ammoPrefab.transform.rotation);
        }
    }
    
    
}
