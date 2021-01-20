using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class lowerMechanic : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y > 0)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 10);
        }
    }
}
