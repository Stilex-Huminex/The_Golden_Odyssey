
using UnityEngine;

public class MoveCameraBis : MonoBehaviour
{

    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}