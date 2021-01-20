using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque4 : MonoBehaviour
{
    public bool P1 = false;
    public Renderer RP1;
    public Material M1;
    public lowerMechanic pont;

    void OnCollisionEnter()
    {
        if (!P1)
        {
            P1 = true;
            RP1.material = M1;
            pont.enabled = true;

        }
    }
}
