using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class WatchManager : MonoBehaviour
{


    [SerializeField] private Radar radar;
    [SerializeField] private GrapplingHook grappin;
    [SerializeField] private Laser laser;
    [SerializeField] private Material[] applications;
    [SerializeField] private Renderer ecran;

    void Start()
    {
        radar.enabled = false;
        grappin.enabled = false;
        laser.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ecran.material = applications[0];
            radar.enabled = true;
            grappin.enabled = false;
            laser.enabled = false;

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && SaveManager.isGrapUnlocked)
        {
            ecran.material = applications[1];
            radar.enabled = false;
            grappin.enabled = true;
            laser.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && SaveManager.isLaserUnlocked)
        {
            ecran.material = applications[2];
            radar.enabled = false;
            grappin.enabled = false;
            laser.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && SaveManager.isWaveUnlocked)
        {
            ecran.material = applications[3];
            radar.enabled = false;
            grappin.enabled = false;
            laser.enabled = false;
        }

    }
}
