using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainVaisseau : MonoBehaviour
{
    Rigidbody rb;
    public int Force;
    public bool pressedUp = false, pressedLeft = false, pressedRight = false;
    public float X,Y, Z;
   




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.D))
        {
            pressedLeft = true;
            Y = 1;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            pressedLeft = false;

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            pressedLeft = true;
            Y = -1;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            pressedLeft = false;
        }


        if (Input.GetKeyDown(KeyCode.Z))
        {
            pressedUp = true;
            Z = 1;
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            pressedUp = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            pressedUp = true;
            Z = -1;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            pressedUp = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressedRight = true;
            X = -1;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            pressedRight = false;

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            pressedRight = true;
            X = 1;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            pressedRight = false;
        }
        
        
        
        if (pressedUp == true)
        {
            rb.AddForce(transform.forward * Z * Force, ForceMode.Impulse);

        }

        if (pressedLeft == true)
        {
            transform.Rotate(0, Y, 0);
        }
        if (pressedRight == true)
        {
            transform.Rotate(X, 0, 0);
        }

    }
}
