using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchManager : MonoBehaviour
{


    [SerializeField] private Radar radar;
    [SerializeField] private GrapplingHook grappin;
    void Start()
    {
        Debug.Log("Woohoooo");
        if (Input.GetKeyDown(KeyCode.Ampersand))
        {
            Debug.Log("Woohoooo");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
