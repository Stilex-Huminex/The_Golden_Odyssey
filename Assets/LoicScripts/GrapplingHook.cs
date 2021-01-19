using System;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{

    private LineRenderer lr;
    private Vector3 pointGrappin;
    [SerializeField] private LayerMask surfaces;
    [SerializeField] private Transform watchTip, view, joueur;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private CharacterController contr;
    [SerializeField] private PlayerMovement move;
    private float maxDistance = 100f;
    private SpringJoint joint;

    [SerializeField] private Transform groundCheck; //position sphere
    [SerializeField] private float groundDistance = 0.4f; // radius of the shpere
    [SerializeField] private LayerMask groundMask;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        DrawRope();
        if (Input.GetMouseButtonDown(0))
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopGrapple();
        }

        if (Physics.CheckSphere(groundCheck.position, groundDistance, groundMask))
        {
            rb.isKinematic = true;
            rb.useGravity = false;
            contr.enabled = true;
            move.enabled = true;
        }
        else if (IsGrappling())
        {
            rb.isKinematic = false;
            rb.useGravity = true;
            contr.enabled = false;
            move.enabled = false;
        }
    }

    void StartGrapple()
    {
        RaycastHit rh;

        if (Physics.Raycast(view.position, view.forward, out rh, maxDistance, surfaces))
        {
            rb.isKinematic = false;
            rb.useGravity = true;
            contr.enabled = false;
            move.enabled = false;

            pointGrappin = rh.point;
            joint = joueur.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = pointGrappin;
            float distanceAuPoint = Vector3.Distance(joueur.position, pointGrappin);
            joint.maxDistance = distanceAuPoint * 0.8f;
            joint.minDistance = distanceAuPoint * 0.25f;

            joint.spring = 4.5f;
            joint.damper = 7f;
            joint.massScale = 4.5f;

            lr.positionCount = 2;
            currentGrapplePosition = watchTip.position;
        }
    }

    /// <summary>
    /// Call whenever we want to stop a grapple
    /// </summary>
    void StopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
    }


    private Vector3 currentGrapplePosition;

    void DrawRope()
    {
        //If not grappling, don't draw rope
        if (!joint) return;

        currentGrapplePosition = Vector3.Lerp(currentGrapplePosition, pointGrappin, Time.deltaTime * 8f);

        lr.SetPosition(0, watchTip.position);
        lr.SetPosition(1, currentGrapplePosition);
    }

    public bool IsGrappling()
    {
        return joint != null;
    }

    public Vector3 GetGrapplePoint()
    {
        return pointGrappin;
    }



}
