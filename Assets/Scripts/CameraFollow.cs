using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El coche
    public Vector3 offset; // Desplazamiento de la cámara
    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    void LateUpdate()
    {
        if (target != null)
        {
            // Posición deseada de la cámara
            Vector3 desiredPosition = target.position + offset;

            // Suavizar movimiento de la cámara
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Rotar la cámara hacia el coche
            Quaternion desiredRotation = Quaternion.Euler(0, target.eulerAngles.y, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, smoothSpeed);
        }
    }
}
