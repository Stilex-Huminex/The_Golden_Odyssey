using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "First Person Player")
        {
            FindObjectOfType<LevelLoader>().LoadLevel(6);
        }
    }
}
