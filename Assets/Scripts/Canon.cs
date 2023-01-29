using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform pointOfShoot;
    [SerializeField] private float secondsToCreate;
    private float secondsToCreateB;
    private void Start()
    {
        secondsToCreateB = secondsToCreate;
    }
    private void Update()
    {
        // CountDown();
    }

    public void CountDown()
    {
        if (secondsToCreateB <= Time.time)
        {
            ShootOnce();
        }
    }

    private void ShootOnce()
    {
        Debug.Log("Shoot once");
        secondsToCreateB = secondsToCreate + Time.time;
        Instantiate(bullet, pointOfShoot.position, pointOfShoot.rotation);
    }

}
