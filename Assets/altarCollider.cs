using NUnit.Framework;
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
    private int numBouton=0;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    public void MapSable()
    {
        popup.fontSize = 40;
        StartCoroutine(DrawPopup("Il me semble que j'ai apperçue une sorte de labyrinthe ... "));

    }
    public void TextScanner()
    {
        StartCoroutine(DrawPopup("Mon scanner devrait m'être utile, utilisez la touche 1 "));
    }
    public void MessageCheckpoint()
    {
        StartCoroutine(DrawPopup("New Checkpoint"));
    }
    public void BoutonAvancement()
    {

        numBouton += 1;
        StartCoroutine(DrawPopup("Vous avez trouvé "+ numBouton + "/3 bouton pour ouvrir la porte !"));
    }
    public void MessageFinMap()
    {
        StartCoroutine(DrawPopup("L'odysseus est hors service ! Mais je vois les cités d'or au loin. Je dois me sortir de la !"));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "First Person Player")
        {
            if (id == 0 && !SaveManager.isGrapUnlocked)
            {
                SaveManager.isGrapUnlocked = true;
                rend.material = materials[0];
                StartCoroutine(DrawPopup("Grappin débloqué, utilisez la touche 2 pour l'équiper."));
            }
            else if (id == 1 && !SaveManager.isLaserUnlocked)
            {
                SaveManager.isLaserUnlocked = true;
                rend.material = materials[1];
                StartCoroutine(DrawPopup("Laser débloqué, utilisez la touche 3 pour l'équiper."));
            }
            else if (id == 2 && !SaveManager.isWaveUnlocked)
            {
                SaveManager.isWaveUnlocked = true;
                rend.material = materials[2];
                StartCoroutine(DrawPopup("Onde débloquée, utilisez la touche 4 pour l'équiper."));
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
