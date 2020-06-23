using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timetodestroy : MonoBehaviour
{
    public float destroytime = 20f;
    private float currenttime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime;
        if (currenttime > destroytime)
        {
            Destroy(gameObject);
        }
        
    }
}
