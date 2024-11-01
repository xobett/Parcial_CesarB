using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] private float backgroundSpeed;
    void Update()
    {
        MoveBackground();
    }

    private void MoveBackground()
    {
        transform.Translate(transform.forward * -backgroundSpeed * Time.deltaTime);
    }
}
