using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsterMove : MonoBehaviour
{
    public GameObject AsterExplosion;
    public GameObject EnemyExplosion;
    float rotationspeed = 3f;
    
    float size;
    Rigidbody aster;
    // Start is called before the first frame update
    void Start()
    {
        size = Random.Range(0.5f, 2f);
        aster = GetComponent<Rigidbody>();
        aster.angularVelocity = Random.insideUnitSphere * rotationspeed;
        aster.velocity = new Vector3(0, 0, Random.Range(-1, -5));
        aster.transform.localScale *= size;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Border")
        {
            return;
        }
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
            GameObject explotion = Instantiate(EnemyExplosion, transform.position, Quaternion.identity);
        }
        if (other.gameObject != null)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject explotion = Instantiate(AsterExplosion, transform.position, Quaternion.identity);
            explotion.transform.localScale *= size;
        }
        if (other.tag == "Player")
        {
            FindObjectOfType<Playe_model>().Death();
            Destroy(FindObjectOfType<EmmiterRun>());
        }
       
     }
}
