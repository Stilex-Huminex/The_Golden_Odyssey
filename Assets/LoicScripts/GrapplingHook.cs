using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{

    private LineRenderer lr;
    private Vector3 pointGrappin;
    public LayerMask surfaces;
    public Transform watchTip, camera, joueur;
    private float maxDistance = 100f;
    private SpringJoint joint;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            /*StopGrapple();*/
        }
    }

    void StartGrapple()
    {
        RaycastHit rh;
        if (Physics.Raycast(camera.position, camera.forward, out rh, maxDistance, surfaces))
        {
            pointGrappin = rh.point;
            joint = joueur.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = pointGrappin;
<<<<<<< Updated upstream
            float distanceAuPoint = Vector3.Distance(joueur.position, pointGrappin);
            joint.maxDistance = distanceAuPoint * 0.8f;
            joint.minDistance = distanceAuPoint * 0.25f;
=======
>>>>>>> Stashed changes
        }
    }

}
