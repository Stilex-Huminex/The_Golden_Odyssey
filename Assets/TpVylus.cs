using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpVylus : MonoBehaviour
{
    // Start is called before the first frame update
    public float targetx;
    public float targety;
    public float targetz;
    public Transform player;



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "First Person Player")
        {
            tp(collision);
        }
    }

    private void tp(Collider collision)
    {
        CharacterController contr = collision.gameObject.GetComponent<CharacterController>(); ;
        PlayerMovement move = collision.gameObject.GetComponent<PlayerMovement>();

        contr.enabled = false;
        move.enabled = false;
        collision.gameObject.transform.position = new Vector3(targetx, targety, targetz);
        contr.enabled = true;
        move.enabled = true;



    }
}
