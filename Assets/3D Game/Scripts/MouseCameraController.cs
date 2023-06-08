using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraController : MonoBehaviour
{
    [SerializeField] CameraController cameraController;

    [SerializeField] float horizontalSensivity = 1;
    [SerializeField] float verticalSensitivity= 1;
    [SerializeField] bool invertMouseVertical = true;

    [SerializeField] bool disableCursor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseMovementX = Input.GetAxis("Mouse X");
        float mouseMovementY = Input.GetAxis("Mouse Y");

        cameraController.horizontalAngle += mouseMovementX;
        float verticalM = invertMouseVertical ? 1 : -1;
        cameraController.verticalAngle -= mouseMovementY;
    }
}
