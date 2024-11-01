using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadSceneAsync(currentScene.name);

            GameManager.instance.asteroidsDestroyed = 0;
            AudioManager.audioInstance.PlayClip("Explosion");
        }
    }
}
