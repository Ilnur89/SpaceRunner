
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ManagerTiles : MonoBehaviour
{
    
    public List<GameObject> objs;

    public GameObject[] TilesArray;
    private float savezone = 15.0f;
    private Transform playertransform;

    private float SpawnZ = 0.0f;
    private float lenprefabs = 10.0f;
    private int numTiles=5;
    private int lastprefab = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
      playertransform= GameObject.FindGameObjectWithTag("Player").transform;
      for(int i = 0; i < numTiles; i++)
        {
            if (i < 3)
            {
                Spawn(0);
            }
            else
            {
                Spawn();
            }
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playertransform == null)
        {
            return;
        }
        if (playertransform.position.z-savezone > (SpawnZ -numTiles*lenprefabs))
        {
            Spawn();
            Delete();
        }
        
    }
    void Spawn(int prefabindx = -1)
    {
       
        GameObject go;
        
        Vector3 position = new Vector3(Random.Range(-0.5f, 0.5f), 0, SpawnZ);
        if (prefabindx == -1)
            go = Instantiate(TilesArray[RandonPrefab()], position, Quaternion.identity);
        else
            go = Instantiate(TilesArray[prefabindx], Vector3.forward*SpawnZ, Quaternion.identity);

        //go.transform.position = Vector3.forward * SpawnZ; 
        SpawnZ += lenprefabs;
        objs.Add(go);
    }
    void Delete()
    {
        Destroy(objs[0]);
        objs.RemoveAt(0);
    }
    int RandonPrefab()
    {
        if (TilesArray.Length <= 1)
            return 0;
        int randomindex = lastprefab;
        while (randomindex==lastprefab)
        {
            randomindex = Random.Range(0, TilesArray.Length);
        }
        lastprefab = randomindex;
        return randomindex;
    }

   
}
