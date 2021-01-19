using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouton1 : MonoBehaviour
{
    public bool Bout1 = false;
    public MeshRenderer B1;
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
        if (Bout1 == false)
        {
            Bout1 = true;
            B1.enabled = false;
            Debug.Log("b1");

        }
    }
}
