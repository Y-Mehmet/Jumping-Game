using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed=20;
    PlayerController pCScript;
    bool isdoublespeed=false;

    

    // Start is called before the first frame update
    void Start()
    {
        pCScript=GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!pCScript.isGameOver)
        {
            transform.Translate(Vector3.left*Time.deltaTime*speed); 
            if(Input.GetKey(KeyCode.T))
            {
                transform.Translate(Vector3.left*Time.deltaTime*2*speed);
                isdoublespeed=true;

            }
            isdoublespeed=false;
        }
       
    }
}
