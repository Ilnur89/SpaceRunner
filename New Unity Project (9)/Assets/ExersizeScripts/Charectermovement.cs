using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charectermovement : MonoBehaviour
{
    private Animator animator;
    private float lane;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        lane = 2.3f;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            if (lane > 1.5f)
                lane--;
        }
        if (Input.GetKeyDown("d"))
        {
            if (lane < 3.3f)
                lane++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("jumping", true);
            Invoke("stopjumping", 0.1f);
        }
        movement = transform.position;
        movement.x = lane;
        
        transform.position = movement;
        transform.Rotate(Vector3.up, 0.0f);

    }
    void stopjumping()
    {
        animator.SetBool("jumping", false);
    }
}

