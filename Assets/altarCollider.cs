using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class altarCollider : MonoBehaviour
{
    [SerializeField] private Text popup;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "First Person Player")
        {
            popup.text = "AAAAAAAA";
        }
    }
}
