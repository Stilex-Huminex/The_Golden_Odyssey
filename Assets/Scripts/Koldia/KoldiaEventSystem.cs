using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoldiaEventSystem : MonoBehaviour
{
    [SerializeField] private GameObject lampadaire1;
    [SerializeField] private GameObject lampadaire2;
    [SerializeField] private GameObject lampadaire3;
    [SerializeField] private GameObject lampadaire4;
    [SerializeField] private GameObject lampadaire5;
    [SerializeField] private GameObject porte2;

    [SerializeField] private GameObject levier2;
    [SerializeField] private GameObject porte3;

    [SerializeField] private GameObject iceCube;
    [SerializeField] private GameObject porte4;


    // Update is called once per frame
    void Update()
    {
        if (
            CheckParticleSystemEnabled(lampadaire1) &&
            CheckParticleSystemEnabled(lampadaire2) &&
            CheckParticleSystemEnabled(lampadaire3) &&
            CheckParticleSystemEnabled(lampadaire4) &&
            CheckParticleSystemEnabled(lampadaire5)
            )
        {
            porte2.SetActive(false);
        }

        if (!iceCube.activeSelf)
        {
            porte4.SetActive(false);
        }
    }

    private bool CheckParticleSystemEnabled(GameObject gameObject)
    {
        ParticleSystem ps = gameObject.GetComponent<ParticleSystem>();

        return ps != null && ps.IsAlive();
    }
}
