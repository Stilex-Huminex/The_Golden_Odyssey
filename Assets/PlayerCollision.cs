using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   

    private float x;
    private float y;
    private float z;

    private string checkpointName = "ImNotACheckpoint";

    

    public void OnTriggerEnter(Collider hit)
    {
        
        if (hit.gameObject.tag == "CheckPoint")
        {
           

            
            if (checkpointName != hit.gameObject.name)
            {
                
                checkpointName = hit.gameObject.name;
                x = transform.position.x;
                y = transform.position.y;
                z = transform.position.z;
               
            }
        }     
    }

    public void OnCollisionEnter(Collision hit)
    {
       
        if (hit.gameObject.tag == "Mort")
        {
            transform.position = new Vector3(x, y, z);
        }
    }
    private void Update()
    {

        if (transform.position.y < -30f)
        {
            transform.position = new Vector3(x, y, z);
        }
    }


}
