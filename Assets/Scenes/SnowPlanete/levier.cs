using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levier : MonoBehaviour
{
    public bool levier1 = false;
    public levier2 L2;
    public GameObject PortePrincipale;

    // Update is called once per frame
    void Update()
    {
        if (PortePrincipale.activeSelf && levier1 == true && L2.Levier2 == true)
        {
            Debug.Log("Une porte s'est ouverte");
            PortePrincipale.SetActive(false);
        }
    }
    void OnCollisionEnter() 
    {
        if (levier1==false)
        {
            levier1 = true;
            transform.Rotate(180, 0, 0);
            
        }
    }
}
