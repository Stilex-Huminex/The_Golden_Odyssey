using UnityEngine;

public class VaisseauColider : MonoBehaviour
{
    public Transform Vaisseau;
    public GameObject panel;
    public GameObject slider;

    private void OnCollisionEnter(Collision hit)
    {
      
        if (hit.gameObject.tag == "Asteroïde")
        {
            Cursor.lockState = CursorLockMode.None;
            FindObjectOfType<MainVaisseau>().enabled = false;
            
            panel.SetActive(true);
            slider.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
    private void OnTriggerEnter(Collider hit)
    {
        


        if (hit.gameObject.name == "Teleportation6")
        {

            Vaisseau.position = new Vector3(Vaisseau.position.x, 8000f, Vaisseau.position.z);
        }
        if (hit.gameObject.name == "Teleportation5")
        {

            Vaisseau.position = new Vector3(Vaisseau.position.x, -14500f, Vaisseau.position.z);
        }
        if (hit.gameObject.name == "Teleportation4")
        {

            Vaisseau.position = new Vector3(Vaisseau.position.x, Vaisseau.position.y, -17500f);
        }
        if (hit.gameObject.name == "Teleportation3")
        {

            Vaisseau.position = new Vector3(21500f, Vaisseau.position.y, Vaisseau.position.z);
        }
        if (hit.gameObject.name == "Teleportation2")
        {

            Vaisseau.position = new Vector3(-16500f, Vaisseau.position.y, Vaisseau.position.z);
        }
        if (hit.gameObject.name == "Teleportation1")
        {

            Vaisseau.position = new Vector3(Vaisseau.position.x, Vaisseau.position.y, 20500f);
        }
    }

}
