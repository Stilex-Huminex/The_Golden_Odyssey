using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Radar : MonoBehaviour
{
    [SerializeField] private GameObject[] traqueurs;
    List<GameObject> pointeurs;
    List<GameObject> pointBordure;
    [SerializeField] private GameObject point;
    [SerializeField] private float distance;
    [SerializeField] private Transform helper;
    [SerializeField] private Camera radar;

    // Start is called before the first frame update
    void Start()
    {
        creationObjetsRadar();   
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButton(0))
        {
            radar.enabled = false;
        }
        else
        {
            radar.enabled = true;
            for (int i = 0; i < pointeurs.Count; i++)
            {
                if (Vector3.Distance(pointeurs[i].transform.position, transform.position) > distance)
                {
                    helper.LookAt(pointeurs[i].transform);
                    pointBordure[i].transform.position = transform.position + distance * helper.forward;
                    pointBordure[i].layer = LayerMask.NameToLayer("Radar");
                    pointeurs[i].layer = LayerMask.NameToLayer("Invisible");
                }
                else
                {
                    pointBordure[i].layer = LayerMask.NameToLayer("Invisible");
                    pointeurs[i].layer = LayerMask.NameToLayer("Radar");

                }
            }
        }
        
    }
    void creationObjetsRadar()
    {
        pointeurs = new List<GameObject>();
        pointBordure = new List<GameObject>();
        foreach (GameObject o in traqueurs)
        {
            GameObject k = Instantiate(point, o.transform.position, Quaternion.identity) as GameObject;
            pointeurs.Add(k);
            GameObject j = Instantiate(point, o.transform.position, Quaternion.identity) as GameObject;
            pointBordure.Add(j);
        }
    }
}
