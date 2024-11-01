using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float boxColliderWidth;

    void Start()
    {
        startPosition = transform.position;
        boxColliderWidth = GetComponent<BoxCollider>().size.z / 2;
    }
    void Update()
    {
        RestartBackground();
    }

    private void RestartBackground()
    {
        if (transform.position.z < startPosition.z - boxColliderWidth)
        {
            transform.position =  startPosition;
        }
    }
}
