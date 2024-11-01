using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

            GameManager.instance.asteroidsDestroyed++;
            AudioManager.audioInstance.PlayClip("Impact");
        }
    }
}
