using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque2 : MonoBehaviour
{
    public bool P2 = false;
    public Renderer RP2;
    public Material M2;
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
        if (P2 == false)
        {
            P2 = true;
            RP2.material = M2;
            Debug.Log("P2");

        }
    }
}
