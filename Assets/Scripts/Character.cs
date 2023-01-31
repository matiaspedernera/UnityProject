using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float speed;
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void MoveCharacter(Vector3 directionToMove)
    {
        transform.position += directionToMove * (speed * Time.deltaTime);
    } 

    private void RotateCharacter(Vector3 rotationToLook)
    {
        transform.Rotate(rotationToLook);
    }
    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var mouse1 = horizontalSpeed * Input.GetAxis("Mouse X");
        var mouse2 = verticalSpeed * Input.GetAxis("Mouse Y");
        var direction = new Vector3(horizontal, 0, vertical);
        var rotation = new Vector3(mouse2, mouse1, 0);
        RotateCharacter(rotation);
        MoveCharacter(direction);
    }
}
