using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipShoot : MonoBehaviour
{
    public GameObject laserBeam;

    private Transform laserSpawnPoint;

    [SerializeField] private float shootForce;

    [SerializeField] private float timer;
    [SerializeField] private float coolDownTime;

    void Start()
    {
        laserSpawnPoint = transform.GetChild(0);
    }

    void Update()
    {
        ShootLaser();
        TimerCheck();
    }

    private void ShootLaser()
    {
        if (ShootCheck() && timer < 0)
        {
            AudioManager.audioInstance.PlayClip("Shoot");

            GameObject clone = Instantiate(laserBeam, laserSpawnPoint.position, laserSpawnPoint.rotation);
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward* shootForce);

            timer = coolDownTime;
        }
    }

    private bool ShootCheck()
    {
        return Input.GetKeyDown(KeyCode.Q);
    }

    private void TimerCheck()
    {
        timer -= Time.deltaTime;
    }
}
