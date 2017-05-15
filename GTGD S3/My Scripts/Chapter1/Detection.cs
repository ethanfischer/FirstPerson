﻿using UnityEngine;
using System.Collections;

namespace Chapter1
{
 public class Detection : MonoBehaviour {

    private RaycastHit hit;
    private LayerMask detectionLayer;
    private float checkRate = .5f;
    private float nextCheck;
    private Transform myTransform;
    private float range = 5;

	// Use this for initialization
	void Start () {
	   setInitialReferences();
       detectionLayer = 1<<9;
	}
	
	// Update is called once per frame
	void Update () {
	   DetectItems();
	}
    
    void setInitialReferences ()
    {
        myTransform = transform;   
    }
    
    void DetectItems () 
    {
        if(Time.time > nextCheck)
        {
            nextCheck = Time.time + checkRate;
            if (Physics.Raycast(myTransform.position, myTransform.forward, out hit, range, detectionLayer))
            {
                Debug.Log(hit.transform.name + "is an item");
            }
        }
    }
}
   
}

