using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchManager : MonoBehaviour
{


    [SerializeField] private Radar radar;
    [SerializeField] private GrapplingHook grappin;
    [SerializeField] private Material[] applications;
    [SerializeField] private Renderer ecran;

    void Start()
    {
        radar.enabled = false;
        grappin.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ecran.material = applications[0];
            radar.enabled = true;
            grappin.enabled = false;

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ecran.material = applications[1];
            radar.enabled = false;
            grappin.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ecran.material = applications[2];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ecran.material = applications[3];
        }

    }
}
