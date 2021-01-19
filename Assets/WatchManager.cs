using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchManager : MonoBehaviour
{


    [SerializeField] private Radar radar;
    [SerializeField] private GrapplingHook grappin;
    [SerializeField] private Material applications;
    [SerializeField] private GameObject ecran;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Woohoooo");
        }

    }
}
