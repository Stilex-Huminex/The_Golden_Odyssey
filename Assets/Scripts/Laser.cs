using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject PrefLaz;
    public GameObject pointFeu;
    public Camera cam;

    private GameObject spawnedLaser;
    void Start()
    {
        spawnedLaser = Instantiate(PrefLaz, pointFeu.transform) as GameObject;
        DesactiverLaser();
        Ray rayon = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit touche;
        LineRenderer liner = spawnedLaser.GetComponentInChildren<LineRenderer>();
        liner.SetPosition(1, rayon.GetPoint(10));
        liner.SetPosition(0, pointFeu.transform.position);
}

    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ActiverLaser();
        }
        if (Input.GetMouseButton(1)) 
        {
            MAJLaser();        
        }
        if (Input.GetMouseButtonUp(1))
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
        Ray rayon = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit touche;
        LineRenderer liner = spawnedLaser.GetComponentInChildren<LineRenderer>();

        //if (Physics.Raycast(rayon, out touche)) 
        //{
        //    spawnedLaser.GetComponentInChildren<LineRenderer>().SetPosition(1, touche.point);
        //}
        //else
        //{
        //float distance = spawnedLaser.GetComponentInChildren<LineRenderer>().GetPosition(1).z - touche.point.z;
        //spawnedLaser.GetComponentInChildren<LineRenderer>().SetPosition(1, rayon.GetPoint(10));
        //}
        if (pointFeu!=null)
        {
            if (Physics.Raycast(rayon, out touche))
            {
                liner.SetPosition(1, touche.point);
            }
            else liner.SetPosition(1, rayon.GetPoint(10));


        }
    }

}
