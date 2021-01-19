using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neige : MonoBehaviour
{
    public Transform joueur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(joueur.position.x, joueur.position.y + 10, joueur.position.z);
    }
}
