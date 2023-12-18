using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public float mouseSensitivity = 2.0f; // Sensibilidad del rat�n para mirar alrededor

    float verticalRotation = 0;
    public float upDownRange = 60.0f; // Rango de movimiento hacia arriba/abajo

    void Start()
    {
        // Ocultar y bloquear el cursor para una experiencia de juego m�s inmersiva
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Rotaci�n de la c�mara con el rat�n
        float rotLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
    }
}
