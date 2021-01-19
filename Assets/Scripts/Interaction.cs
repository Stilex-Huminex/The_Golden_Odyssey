using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private int id;

    public void Interact()
    {
        GameObject go = this.gameObject;

        // 1 - Lampadaires
        if (id == 1)
        {
            ParticleSystem ps = go.GetComponent<ParticleSystem>();

            if (SaveManager.currentWeapon == "laser" && !ps.main.playOnAwake) {
                ps.Play();
            }
        }

        // 2 - cailloux (grotte glace)
        if (id == 2)
        {
            if (SaveManager.currentWeapon == "laser")
            {
                go.SetActive(false);
            }
        }
    }
}
