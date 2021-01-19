using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouton2 : MonoBehaviour
{
    public bool Bout2 = false;
    public MeshRenderer B2;
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
        if (Bout2 == false)
        {
            Bout2 = true;
            B2.enabled = false;
            Debug.Log("b2");

        }
    }
}
