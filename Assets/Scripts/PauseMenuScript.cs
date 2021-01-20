using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    private bool paused = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        if (paused)
        {
            Debug.Log("Resuming");
            // resume
            Time.timeScale = 1.0f;
            this.gameObject.GetComponent<Canvas>().enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
        } else
        {
            Debug.Log("Pausing");
            // pause the game
            Cursor.lockState = CursorLockMode.None;
            this.gameObject.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0.0f;
        }

        paused = !paused;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
