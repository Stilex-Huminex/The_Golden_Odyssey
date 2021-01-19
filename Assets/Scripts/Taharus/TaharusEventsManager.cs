using UnityEngine;

public class TaharusEventsManager : MonoBehaviour
{
    [SerializeField] private GameObject porte;

    private bool button1, button2, button3;

    public void ButtonPress(int id)
    {
        switch (id)
        {
            case 1:
                button1 = true;
                break;
            case 2:
                button2 = true;
                break;
            case 3:
                button3 = true;
                break;
        }

        // deactivate the door
        if (button1 && button2 && button3)
        {
            porte.SetActive(false);
        }
    }

}
