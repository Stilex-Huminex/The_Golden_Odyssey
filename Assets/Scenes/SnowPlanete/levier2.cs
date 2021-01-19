using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levier2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Levier2 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter()
    {
        if (Levier2==false)
        {
            Levier2 = true;
            transform.Rotate(180, 0, 0);
            Debug.Log("fefe");
        }
    }
}
