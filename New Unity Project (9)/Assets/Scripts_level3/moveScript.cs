using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    Rigidbody enemy;
    
    Transform player;
    public GameObject LaserShot;
    public GameObject LaserGun;
    private float Bulletforward=3000;
    

    float next;

    // Start is called before the first frame update
    void Start()
    {

        enemy = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

    void Update()
    {
        if (player == null)
        {
            return;
        }

        if (Vector3.Distance(transform.position, player.position) > 10 )
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * 10);
            transform.LookAt(player.position);

        }
        else 
        {
            //transform.LookAt(player.position);

            transform.position = Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * -10);
            enemy.velocity = new Vector3(Random.Range(-1, 1) * Time.deltaTime, 0, 0);
            float shootdelay = Random.Range(0.7f, 0.1f);
            if (Time.time > next)
            {

                GameObject laserhundler;
                laserhundler = Instantiate(LaserShot, LaserGun.transform.position, LaserGun.transform.rotation) as GameObject;
                Rigidbody temprorary;
                temprorary = laserhundler.GetComponent<Rigidbody>();
                temprorary.AddForce(transform.forward * Bulletforward);
                next = Time.time + shootdelay;
            }
        }
        
        
    }
   
}
