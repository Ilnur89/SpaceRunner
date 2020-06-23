using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderLookAt : MonoBehaviour
{
    private Transform lookat;
    private Vector3 movement;
    Vector3 starofset;
   
    void Start()
    {
        lookat = GameObject.FindGameObjectWithTag("Player").transform;
        starofset = transform.position + lookat.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (lookat == null)
        {
            return;
        }
        movement = lookat.position + starofset;
        movement.x = 0.0f;
        movement.y = 0.0f;
        transform.position = movement;

    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        
    }
}
