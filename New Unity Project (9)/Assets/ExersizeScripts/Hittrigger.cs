using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittrigger : MonoBehaviour
{

    
    public Transform roadprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider colider)
    {
        Instantiate(roadprefab, new Vector3(0, 0, transform.parent.position.z+100f), roadprefab.rotation);
        transform.parent.gameObject.AddComponent<Timetodestroy>();
    }
}
