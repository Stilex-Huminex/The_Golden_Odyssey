﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque1 : MonoBehaviour
{
    public bool P1 = false;
    public Renderer RP1;
    public Material M1;
    void Start()
    {
        FindObjectOfType<MapVilleCollider>().MapVille();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (P1 == false && collision.gameObject.layer != 8 && collision.gameObject.layer != 11)
        {
            P1 = true;
            RP1.material = M1;
            FindObjectOfType<MapVilleCollider>().PlaqueAvancement();
        }
    }
}
