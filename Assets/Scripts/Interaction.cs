using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private int stoneID;
    [SerializeField] private Text popupText;

    private int previousStoneCount = -1;

    public int getID()
    {
        return id;
    }

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

        // Altars
        if (id == 9)
        {
            Debug.Log("Activated altar " + stoneID);

            // display text to the user
            int count = (SaveManager.stone1 ? 1 : 0) + (SaveManager.stone2 ? 1 : 0) + (SaveManager.stone3 ? 1 : 0);

            if (previousStoneCount < count)
            {
                // évite de répéter le popup
                switch (count)
                {
                    case 0:
                        StartCoroutine(DrawPopup("Ces symboles sont étranges mais ils semblent familiers..."));
                        break;
                    case 1:
                        StartCoroutine(DrawPopup("Je sais que j'ai déjà vu ces coordonnées quelque part..."));
                        break;
                    case 2:
                        StartCoroutine(DrawPopup("Le soleil ! Ce sont les coordonnées du soleil !"));
                        break;
                }
                previousStoneCount = count;
            }
            

            // save that we saw the stone
            switch (stoneID)
            {
                case 1:
                    SaveManager.stone1 = true;
                    break;
                case 2:
                    SaveManager.stone2 = true;
                    break;
                case 3:
                    SaveManager.stone3 = true;
                    break;
            }
        }

    }

    private IEnumerator DrawPopup(string texte)
    {
        popupText.text = texte;
        yield return new WaitForSeconds(2.5f);
        popupText.text = "";
    }
}
