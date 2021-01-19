﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public Camera cam;
    public GameObject projectile;
    public Transform PointFeu;

    private Vector3 destination;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Tirer();
        }
    }

    void Tirer()
    {
        Ray rayon = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit touche;

        if (Physics.Raycast(rayon, out touche))
            destination = touche.point;
        else
            destination = rayon.GetPoint(1000);

        InitProj();
    }

    void InitProj()
    {
        var projObj = Instantiate(projectile, PointFeu.position, Quaternion.identity) as GameObject;
    }
}
