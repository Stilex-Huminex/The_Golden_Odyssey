using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDown : MonoBehaviour
{
    // Start is called before the first frame update
    public void descendre()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
    }
}
