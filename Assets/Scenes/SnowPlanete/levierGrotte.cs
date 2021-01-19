using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levierGrotte : MonoBehaviour
{
    public bool LevierGrotte = false;
    public GameObject Porte2grotte;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (LevierGrotte == true)
        {
            Debug.Log("Une porte s'est ouverte dans la grotte");
            Porte2grotte.SetActive(false);
        }
    }
    void OnCollisionEnter()
    {
        if (LevierGrotte == false)
        {
            LevierGrotte = true;
            transform.Rotate(180, 0, 0);
            
        }
    }
}
