using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public float mouseSensitivity = 2.0f; // Sensibilidad del ratón para mirar alrededor

    float verticalRotation = 0;
    public float upDownRange = 60.0f; // Rango de movimiento hacia arriba/abajo

    void Start()
    {
        // Ocultar y bloquear el cursor para una experiencia de juego más inmersiva
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Rotación de la cámara con el ratón
        float rotLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
    }
}
