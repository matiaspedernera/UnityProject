using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public int damage;
    [SerializeField] private float secondsToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        DestroyBullet(secondsToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Grow();
        }
        // Countdown();
    }
    public void Grow()
    {
        Debug.Log("Grow");
        transform.localScale = transform.localScale * 2;
    }
    public void DestroyBullet (float secsToDestroy)
    {
        Destroy(gameObject, secsToDestroy);
    }
}
