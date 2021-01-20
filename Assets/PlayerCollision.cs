using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    

    private float x=0;
    private float y=0;
    private float z=0;

    private string checkpointName = "ImNotACheckpoint";

    private void Start()
    {
        gameObject.SetActive(false);
        gameObject.SetActive(true);
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }
    
    public void OnTriggerEnter(Collider hit)
    {
        /*
        if (hit.gameObject.tag == "CheckPoint")
        {   
            if (checkpointName != hit.gameObject.name)
            {
                
                checkpointName = hit.gameObject.name;
                x = transform.position.x;
                y = transform.position.y;
                z = transform.position.z;
                
                        
               
            }
        */
        if (hit.gameObject.name == "Cube")
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
