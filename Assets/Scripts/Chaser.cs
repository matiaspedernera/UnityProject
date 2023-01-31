using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    [SerializeField] private Transform characterTransform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChaseCharacter();
    }

    public void ChaseCharacter() 
    {
        transform.LookAt(characterTransform);
        var characterVector = characterTransform.position - transform.position;
        if (characterVector.magnitude > 2 )
        {
            transform.position = Vector3.MoveTowards(transform.position, characterTransform.position, Time.deltaTime * speed);
        }
    }
}
