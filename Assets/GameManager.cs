using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text popup;


    void Start()
    {
        StartCoroutine(DrawPopup(" Manuel : \n - ZQSD déplacement horizontaux et verticaux \n - LeftShift Espace Rotation"));
    }
    public void réparation()
    {
        FindObjectOfType<MainVaisseau>().enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        FindObjectOfType<ProgressBar>().IncrementProgress(1f);
        
    }

    private IEnumerator DrawPopup(string texte)
    {
        popup.text = texte;
        yield return new WaitForSeconds(10f);
        popup.text = "";
    }
}
