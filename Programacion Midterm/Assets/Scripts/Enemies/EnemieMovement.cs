using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieMovement : MonoBehaviour
{
    [SerializeField] private float enemySpeed;

    private Rigidbody enemyRb;

    private void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ForwardMovement();
    }

    private void ForwardMovement()
    {
        enemyRb.AddForce(transform.forward * -enemySpeed);
    }
}
