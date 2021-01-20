using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque2 : MonoBehaviour
{
    public bool P2 = false;
    public Renderer RP2;
    public Material M2;
    void Start()
    {
        FindObjectOfType<MapVilleCollider>().MapVille();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (P2 == false && collision.gameObject.layer != 8)
        {
            P2 = true;
            RP2.material = M2;
            FindObjectOfType<MapVilleCollider>().PlaqueAvancement();
        }
    }
}
