using UnityEngine;

public class EmmiterRun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Asteroid;
    float mindelay = -1.5f;
    float maxdelay = 1f;
    float nextLan;
    float positionZ;
    float positionX;
    float positionY;
    
  
    // Update is called once per frame
    void Update()
    {
        positionZ = transform.position.z;
        positionY = transform.position.y;
        positionX = Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2);

        if (Time.time > nextLan)
        {
            Instantiate(Asteroid, new Vector3(positionX, positionY, positionZ), Quaternion.identity);
            nextLan = Time.time + Random.Range(mindelay, maxdelay);
        }
    }
   
}
