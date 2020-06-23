using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Playe_model : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;
    
    private float speed = 5.0f;
    private Vector3 movement;

    public bool flag = false;
   
    private float gravity=10.0f;
    private float beganmove = 0.0f;
    private float jspeed=0;


    private float animduration = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        beganmove = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == null)
        {
            return;
        }
        movement.x = Input.GetAxisRaw("Horizontal") * speed;

        //if (flag)
        //    return;

        if (Time.time-beganmove < animduration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }



        //movement = Vector3.zero;

        if (controller.isGrounded)
        {

            jspeed = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jspeed = gravity;
                anim.SetBool("isRun", true);
            }
            else
                anim.SetBool("isRun", false);
        }
        else
        {
            jspeed -= gravity * Time.deltaTime * 3;
            
        }
        if (controller.transform.position.y <= -10.0f)
        {
            Death();
            Destroy(FindObjectOfType<EmmiterRun>());
            Destroy(FindObjectOfType<EmitterEnemy>());
        }
       



        movement.y = jspeed;
        movement.z = speed;

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width/2)
            {
                movement.x = speed;
            }
            else
            {
                movement.x = -speed;
            }
        }

        
        
        controller.Move(movement * Time.deltaTime);
        
       
        
    }
   public void SetSpeed(float increase)
    {
        speed = 3.0f + increase;
    }
    public void Death()
    {
       
        flag = true;
        GetComponent<Score>().OnisDead();
    }
  
    
}
