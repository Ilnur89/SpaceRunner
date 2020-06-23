using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsScript : MonoBehaviour
{
    Rigidbody coins;
    float rotationspeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        coins = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationspeed, 0);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Score.instance.IncreaseScore(100);
        }
    }
}
