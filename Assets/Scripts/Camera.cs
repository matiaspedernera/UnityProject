using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera ThirdPersonCamera;
    [SerializeField] private Camera OrthographicCamera;
    private bool firstCameraOn;
    // Start is called before the first frame update
    void Start()
    {
        firstCameraOn = true;
        ThirdPersonCamera.gameObject.SetActive(firstCameraOn);
        OrthographicCamera.gameObject.SetActive(!firstCameraOn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchCameras();
        }
    }

    private void SwitchCameras()
    {
        if (firstCameraOn)
        {
            ThirdPersonCamera.gameObject.SetActive(false);
            OrthographicCamera.gameObject.SetActive(true);
            firstCameraOn = false;
        } else
        {
            ThirdPersonCamera.gameObject.SetActive(true);
            OrthographicCamera.gameObject.SetActive(false);
            firstCameraOn = true;
        }
    }
}
