using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockMovement : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = transform.gameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, 0, 5));
    }
}
