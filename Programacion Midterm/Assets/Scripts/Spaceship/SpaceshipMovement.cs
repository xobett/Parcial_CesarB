using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody spaceshipRb;

    [SerializeField] private float velocity;

    void Start()
    {
        spaceshipRb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        spaceshipRb.velocity = transform.right * HorizontalInput() * velocity;
    }

    private float HorizontalInput()
    {

        return Input.GetAxis("Horizontal");
    }
}
