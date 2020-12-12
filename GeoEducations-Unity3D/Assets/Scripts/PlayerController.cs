using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody physics;
    public int speed;

    private int point=0;
    public Text PointCounter;


    private int lootCount;
    
    void Start()
    {
        physics = GetComponent<Rigidbody>();

        lootCount = GameObject.FindGameObjectsWithTag("Loot").Length;
    }

    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // Sol: -1 No click: 0  Sag: 1
        float vertical = Input.GetAxisRaw("Vertical");
        
        Vector3 vec = new Vector3(horizontal,0,vertical);
        
        physics.AddForce(vec*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Loot")
        {
            //Debug.Log("They touched!");
            point+=1; // point++ // point=point+1
            Destroy(other.gameObject);

            PointCounter.text = "Point: "+point;

            if (lootCount == point)
            {
                PointCounter.text = "Game Over!";
                Time.timeScale = 0;
            }
            
        }
    }
}
