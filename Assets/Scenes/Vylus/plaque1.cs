using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque1 : MonoBehaviour
{
    public bool P1 = false;
    public Renderer RP1;
    public Material M1;
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
        if (P1 == false)
        {
            P1 = true;
            RP1.material = M1;
            Debug.Log("P1");

        }
    }
}
