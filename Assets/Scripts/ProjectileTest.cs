using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTest : MonoBehaviour
{
    private bool collision;
    private int count = 0;
    private float timeleft = 3;

    void OnCollisionEnter(Collision co)
    {
        if (co.gameObject.tag != "Proj" && co.gameObject.tag != "Player" && !collision)
            {
                //count++;
                //if(count==3)
                //{
                //    collision = true;
                //    Destroy(gameObject);
                //}
                collision = true;
                Destroy(gameObject);
            }
    }
}
