using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject[] obstaclePrefab ;
    Vector3 spawnPos= new Vector3(25,0,0);
    float startDelay=2,repeatRate=4;
    public int obstaclePrefabIndex;
    PlayerController pCScript;
    // Start is called before the first frame update
    void Start()
    {
        pCScript=GameObject.Find("Player").GetComponent<PlayerController>();
        
        {
            InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    { obstaclePrefabIndex= Random.Range(0,4);
        if(!pCScript.isGameOver)
        Instantiate(obstaclePrefab[obstaclePrefabIndex],spawnPos,obstaclePrefab[obstaclePrefabIndex].transform.rotation);
    }
}
