﻿using System.Collections;
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

    public void MessageCheckpoint()
    {
        StartCoroutine(DrawPopup("New Checkpoint"));
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
                    StartCoroutine(DrawPopup("Grappin débloqué, utilisez la touche 2 pour l'équiper."));
                    break;
                case 1:
                    SaveManager.isLaserUnlocked = true;
                    rend.material = materials[1];
                    StartCoroutine(DrawPopup("Laser débloqué, utilisez la touche 3 pour l'équiper."));
                    break;
                case 2:
                    SaveManager.isWaveUnlocked = true;
                    rend.material = materials[2];
                    StartCoroutine(DrawPopup("Onde débloquée, utilisez la touche 4 pour l'équiper."));
                    break;
            }
        }
    }

    private IEnumerator DrawPopup(string texte)
    {
        popup.text = texte;
        yield return new WaitForSeconds(2.5f);
        popup.text = "";
    }
}
