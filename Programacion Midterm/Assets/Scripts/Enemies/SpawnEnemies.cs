using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    [SerializeField] private float enemySpeed;

    [SerializeField] private float spawnSpeed;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private Vector3 RandomSpawnGenerator()
    {
        int randomX = Random.Range(-35, 35);

        Vector3 newSpawnPos = new Vector3(randomX, 0, 80);

        return newSpawnPos;
    }

    private IEnumerator SpawnEnemy()
    {
        GameObject clone = Instantiate(enemy, RandomSpawnGenerator(), Quaternion.identity);

        clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * -enemySpeed);

        yield return new WaitForSeconds(spawnSpeed);

        StartCoroutine(SpawnEnemy());
    }
}
