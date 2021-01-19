using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouton3 : MonoBehaviour
{
    public bool Bout3 = false;
    public MeshRenderer B3;
    public GameObject PorteDonjonS;
    public bouton2 B2;
    public bouton1 B1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Bout3 == true && B2.Bout2 == true && B1.Bout1 == true)
        {
            Debug.Log("Une porte s'est ouverte");
            PorteDonjonS.SetActive(false);
        }
    }
    void OnCollisionEnter()
    {
        if (Bout3 == false)
        {
            Bout3 = true;
            B3.enabled = false;
            Debug.Log("b3");

        }
    }
}
