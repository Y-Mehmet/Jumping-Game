﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
     float backgroundLimit;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos=transform.position;
        backgroundLimit=GetComponent<BoxCollider>().size.x/2;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x-startPos.x<=-backgroundLimit)
        {
            transform.position=startPos;
        }
}
}
