using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 spawn;
    private void Start()
    {
        spawn = transform.position;
        rb = transform.gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.position.y <= 0)
        {
            transform.position = spawn;
            rb.velocity = new Vector3(0, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, 0, 5));
    }
}
