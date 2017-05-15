using UnityEngine;
using System.Collections;

public class CameraFOV : MonoBehaviour {

    public float fov;
    public float focusRate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
    if (Input.GetKeyDown("e"))
    {
    //    float updateRate = 3f;
    //    float tick = 0f;
    //    while(fov < 150)
    //    {
    //        if(tick % 120 > 0.5f)
    //        {
    //             fov = fov + focusRate;   
    //        }
    //        else
    //        {
    //            tick += .0001f;
    //        }
            if(fov > 60f)
            {
                fov -= 10f;
            }
            else
            {
                fov = 60f;
            }
        // }


    }
    else if(Input.GetKeyDown("q"))
    {
        if (fov < 150f)
        {
           fov += 10f;
        }
        else
        {
            fov = 150f;
        }

    }

    
    	   GetComponent<Camera>().fieldOfView = fov;
	}
}
