using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    

    public void réparation()
    {
        FindObjectOfType<MainVaisseau>().enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        FindObjectOfType<ProgressBar>().IncrementProgress(1f);
        
    }

}
