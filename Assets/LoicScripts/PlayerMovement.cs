using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;

    [SerializeField] private float speed = 12f;
    
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumHeight = 3f;

   


    [SerializeField] private Transform groundCheck; //position sphere
    [SerializeField] private float groundDistance = 0.4f; // radius of the shpere
    [SerializeField] private LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded; // savoir si on touche le sol


    void Update()
    {
        // créer une spère invisible en dessous du perso et si elle touche quelque chose isgrounded devient true
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // force le joueur sur le sol, pour sa qu'on met pas a 0

        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        if (Input.GetKey("left shift"))
        {
            speed = 18f;
        }
        else
        {
            speed = 12f;
        }

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumHeight * -2f * gravity); // forume de mazth op
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}

