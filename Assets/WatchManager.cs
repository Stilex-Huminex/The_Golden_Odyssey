using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class WatchManager : MonoBehaviour
{


    [SerializeField] private Radar radar;
    [SerializeField] private GrapplingHook grappin;
    [SerializeField] private Laser laser;
    [SerializeField] private Beam wave;
    [SerializeField] private Material[] applications;
    [SerializeField] private Renderer ecran;

    void Start()
    {
        radar.enabled = false;
        grappin.enabled = false;
        laser.enabled = false;
        wave.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || SaveManager.currentWeapon == "radar")
        {
            ecran.material = applications[0];
            radar.enabled = true;
            grappin.enabled = false;
            laser.enabled = false;
            wave.enabled = false;
            SaveManager.currentWeapon = "radar";

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && SaveManager.isGrapUnlocked || SaveManager.currentWeapon == "grappin")
        {
            ecran.material = applications[1];
            radar.enabled = false;
            grappin.enabled = true;
            laser.enabled = false;
            wave.enabled = false;
            SaveManager.currentWeapon = "grappin";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && SaveManager.isLaserUnlocked || SaveManager.currentWeapon == "laser")
        {
            ecran.material = applications[2];
            radar.enabled = false;
            grappin.enabled = false;
            laser.enabled = true;
            wave.enabled = false;
            SaveManager.currentWeapon = "laser";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && SaveManager.isWaveUnlocked || SaveManager.currentWeapon == "beam")
        {
            ecran.material = applications[3];
            radar.enabled = false;
            grappin.enabled = false;
            laser.enabled = false;
            wave.enabled = true;
            SaveManager.currentWeapon = "beam";
        }

    }
}
