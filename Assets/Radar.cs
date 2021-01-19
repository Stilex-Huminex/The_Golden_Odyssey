using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Radar : MonoBehaviour
{
    [SerializeField] private GameObject[] traqueurs;
    List<GameObject> pointeurs;
    [SerializeField] private GameObject point;

    // Start is called before the first frame update
    void Start()
    {
        creationObjetsRadar();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void creationObjetsRadar()
    {
        pointeurs = new List<GameObject>();
        foreach(GameObject o in traqueurs)
        {
            GameObject k = Instantiate(point, o.transform.position, Quaternion.identity) as GameObject;
        }
    }
}
