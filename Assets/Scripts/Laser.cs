using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject PrefLaz;
    public GameObject pointFeu;

    private GameObject spawnedLaser;
    void Start()
    {
        spawnedLaser = Instantiate(PrefLaz, pointFeu.transform) as GameObject;
        DesactiverLaser();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ActiverLaser();
        }
        if (Input.GetMouseButton(0)) 
        {
            MAJLaser();        
        }
        if (Input.GetMouseButtonUp(0))
        {
            DesactiverLaser();
        }
    }

    void ActiverLaser()
    {
        spawnedLaser.SetActive(true);
    }

    void DesactiverLaser()
    {
        spawnedLaser.SetActive(false);
    }
    void MAJLaser()
    {
        if(pointFeu!=null)
        {
            spawnedLaser.transform.position = pointFeu.transform.position;
        }
    }

}
