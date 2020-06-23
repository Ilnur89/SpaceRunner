using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EmitterEnemy : MonoBehaviour
{
    
    public Transform Enemys;
   
    
    float mindelay = 5f;
    float maxdelay = 10f;
    float nextenemy;
    float posx;
    float posy;
    float posz;
    
    void Update()
    {
        
        posz = transform.position.z;
        posy = transform.position.y;
       
        posx = Random.Range(-transform.localScale.x/2, transform.localScale.x/2);

        
        if (Time.time > nextenemy)
        {

            
            Instantiate(Enemys, new Vector3(posx, posy, posz),Quaternion.identity);
            
            nextenemy = Random.Range(mindelay, maxdelay) + Time.time;
        }
    }
}
