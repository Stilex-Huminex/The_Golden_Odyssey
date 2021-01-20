using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque3 : MonoBehaviour
{
    public bool P3 = false;
    public Renderer RP3;
    public Material M3;
    public plaque2 pl2;
    public plaque1 pl1;
    public GameObject Transporter;
    // Start is called before the first frame update
    void Start()
    {
        Transporter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (P3 == true && pl2.P2 == true && pl1.P1 == true && !Transporter.activeSelf)
        {
            Transporter.SetActive(true) ;
        }
    }
    void OnCollisionEnter()
    {
        if (P3 == false)
        {
            P3 = true;
            RP3.material = M3;
            Debug.Log("P3");

        }
    }
}
