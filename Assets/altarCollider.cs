using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class altarCollider : MonoBehaviour
{
    [SerializeField] private Text popup;
    [SerializeField] private int id;
    private Renderer rend;
    [SerializeField] private Material[] materials;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "First Person Player")
        {
            switch (id)
            {
                case 0:
                    SaveManager.isGrapUnlocked = true;
                    rend.material = materials[0];
                    break;
                case 1:
                    SaveManager.isLaserUnlocked = true;
                    rend.material = materials[1];
                    break;
                case 2:
                    SaveManager.isWaveUnlocked = true;
                    rend.material = materials[2];
                    break;
            }
        }
    }
}
