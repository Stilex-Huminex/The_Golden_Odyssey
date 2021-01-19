using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject panel;

    public void réparation()
    {
        FindObjectOfType<MainVaisseau>().enabled = true;
        panel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

}
