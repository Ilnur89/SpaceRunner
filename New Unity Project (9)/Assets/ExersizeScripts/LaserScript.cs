using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    private float speed = -10f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>();
    }
    private void Update()
    {
        transform.Translate(transform.right * speed);
    }

}
