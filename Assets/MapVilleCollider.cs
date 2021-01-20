using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MapVilleCollider : MonoBehaviour
{
    [SerializeField] private Text popup;
    private Renderer rend;
    [SerializeField] private Material[] materials;
    private int numPlaque = 0;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    public void MapVille()
    {
        popup.fontSize = 40;
        StartCoroutine(DrawPopup("Et si j'appuyais sur les plaques de pressions ?... "));
    }

    public void PlaqueAvancement()
    {
        numPlaque += 1;
        StartCoroutine(DrawPopup("Vous avez trouvé " + numPlaque + "/3 plaque pour accéder au téléporteur"));
        if (numPlaque == 3)
        {
            StartCoroutine(DrawPopup("Le téléporteur s'est activé !"));
        }
    }
    private IEnumerator DrawPopup(string texte)
    {
        popup.text = texte;
        yield return new WaitForSeconds(2.5f);
        popup.text = "";
    }
}
