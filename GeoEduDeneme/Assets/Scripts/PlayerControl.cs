using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody physics;
    public int speed;

    public Text CountText;
    private int pointCounter;
    public int totalCount;
    private Time _time;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
        totalCount = GameObject.FindGameObjectsWithTag("Loot").Length;
    }
    
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 vec = new Vector3(horizontal,0,vertical);
        physics.AddForce(vec*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Loot")
        {
            Destroy(other.gameObject);
            pointCounter++;
            CountText.text = "Point: " + pointCounter;
        }

        if (pointCounter==totalCount)
        {
            CountText.text = "Game is over!!!!!!";
            Time.timeScale = 0;
        }
    }

}