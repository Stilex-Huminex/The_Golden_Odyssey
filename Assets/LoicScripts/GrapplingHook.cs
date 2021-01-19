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
        }
    }

    void StopGrapple()
    {

    }

    void DrawRope() 
    {
        lr.SetPosition(0, watchTip.position);
        lr.SetPosition(1, pointGrappin);
    }



}
