using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    
    Rigidbody rb;
    public float speed=10f;
    private float verticalVelocity = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.velocity=new Vector3(0, rb.velocity.y, speed*Time.deltaTime);
        if (Input.GetKeyDown("a"))
        {
            rb.velocity = new Vector3(-100, 0, 0);
        }
        if (Input.GetKeyDown("d"))
        {
            rb.velocity = new Vector3(100, 0, 0);
        }
        

    }
   
}
