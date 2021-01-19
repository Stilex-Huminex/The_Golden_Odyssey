using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public GameObject PrefBeam;
    public GameObject pointFeu;

    private GameObject spawnedBeam;
    void Start()
    {
        spawnedBeam = Instantiate(PrefBeam, pointFeu.transform) as GameObject;
        DesactiverRayon();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ActiverRayon();
        }
        if (Input.GetMouseButton(0))
        {
            MAJRayon();
        }
        if (Input.GetMouseButtonUp(0))
        {
            DesactiverRayon();
        }
    }

    void ActiverRayon()
    {
        spawnedBeam.SetActive(true);
    }

    void DesactiverRayon()
    {
        spawnedBeam.SetActive(false);
    }
    void MAJRayon()
    {
        if (pointFeu != null)
        {
            spawnedBeam.transform.position = pointFeu.transform.position;
        }
    }

}

