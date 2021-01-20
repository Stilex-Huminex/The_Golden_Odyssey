
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class hihi : MonoBehaviour
{
    public Text popup;
    void Start()
    {
        StartCoroutine(DrawPopup(" L'odysseus est hors service ! Mais je vois les cités d'or au loin. Je dois partir d'ici !"));
    }
    

    private IEnumerator DrawPopup(string texte)
    {
        popup.text = texte;
        yield return new WaitForSeconds(10f);
        popup.text = "";
    }
}
   

