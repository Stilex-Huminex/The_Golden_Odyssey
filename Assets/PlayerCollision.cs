using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public CharacterController contr;
    public PlayerMovement move;


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
       
        if (hit.gameObject.tag == "CheckPoint")
            
        {
            if (checkpointName != hit.gameObject.tag)
            {
                checkpointName = hit.gameObject.tag;
                Debug.Log(checkpointName);
                x = transform.position.x;
                y = transform.position.y;
                z = transform.position.z;
                FindObjectOfType<altarCollider>().MessageCheckpoint();
            }
        }


        if (hit.gameObject.name == "Lave" || hit.gameObject.tag == "Mort")
            {

            contr.enabled = false;
            move.enabled = false;
            transform.position = new Vector3(x, y, z);
            contr.enabled = true;
            move.enabled = true;
            
            }

        if (hit.gameObject.name == "TextScannerN")
        {
            FindObjectOfType<altarCollider>().TextScanner();
            
        }
        

    }
   
    
    void Update()
    {

        if (transform.position.y < -30f)
        {
            transform.position = new Vector3(x, y, z);
        }

        
    }
   

}
