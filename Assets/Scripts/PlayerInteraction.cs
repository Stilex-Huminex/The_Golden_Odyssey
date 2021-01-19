using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private LayerMask layer;
    [SerializeField] private Transform view;

    [SerializeField] private int maxDistance;

    // Update is called once per frame
    void Update()
    {
        RaycastHit rh;

        if (Physics.Raycast(view.position, view.forward, out rh, maxDistance, layer))
        {
            Interaction i = rh.collider.gameObject.GetComponent<Interaction>();

            if (Input.GetMouseButton(0) && SaveManager.currentWeapon == "laser")
            {
                i.Interact();
            }
            
        }
    }
}
