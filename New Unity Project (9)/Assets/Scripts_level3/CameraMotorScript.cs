using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotorScript : MonoBehaviour
{
    private Transform lookAt;
    private Vector3 startofset;
    private Vector3 moveVector;

    private float transition = 0.0f;
    private float animduration = 3.0f;
    private Vector3 animofsset = new Vector3(0, 5, 3);
    // Start is called before the first frame update
    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        
        //GameObject.FindGameObjectWithTag("Player").transform;
        startofset = transform.position - lookAt.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (lookAt == null)
        {
            return;
        }

        moveVector = lookAt.position + startofset;
        moveVector.x = 0.0f;
       
        moveVector.y = Mathf.Clamp(moveVector.y,3,7);
        if (transition > 1.0f)
        {
            transform.position = moveVector;
        }
        else
        {
            transform.position = Vector3.Lerp(moveVector + animofsset, moveVector, transition);
            transition += Time.deltaTime * 1 / animduration;
            transform.LookAt(lookAt.position + Vector3.up);
        }
    }
}
