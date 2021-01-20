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
            Debug.Log("Avant1" + collision.gameObject.transform.position);
            Debug.Log("Avant2" + new Vector3(targetx, targety, targetz));
            collision.gameObject.transform.position = new Vector3(targetx, targety, targetz);
            Debug.Log("Après1" + collision.gameObject.transform.position);
            Debug.Log("Après2" + new Vector3(targetx, targety, targetz));
        }
    }
}
