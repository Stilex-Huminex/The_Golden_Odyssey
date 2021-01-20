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

        // 3 - glaçon
        if (id == 3)
        {
            if (SaveManager.currentWeapon == "laser")
            {
                Vector3 scale = go.transform.localScale;

                if (scale.x <= 0.15f || scale.y <= 0.15f || scale.z <= 0.15f)
                {
                    go.SetActive(false);
                } else
                {
                    go.transform.localScale = new Vector3(scale.x - 0.05f, scale.y - 0.05f, scale.z - 0.05f);
                }

            }
        }

        if (id == 4)
        {
            if (SaveManager.currentWeapon == "beam")
            {
                Debug.Log("On intéragit");
                Transform p = go.transform.parent;
                Debug.Log(p.rotation.y);
                if (p.rotation.y <= 0.7f)
                {
                    p.rotation = new Quaternion(p.rotation.x, p.rotation.y + 0.005f, p.rotation.z, p.rotation.w);
                }
                else
                {
                    p.rotation = new Quaternion(p.rotation.x, 0.7071068f, p.rotation.z, p.rotation.w);
                }
            }
        }


        if (id == 5)
        {
            if (SaveManager.currentWeapon == "beam")
            {
                Transform p = go.transform.parent;
                p.RotateAround(p.position, Vector3.up, 20f * Time.deltaTime);
            }
        }

    }
}
