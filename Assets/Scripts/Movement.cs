using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarController : MonoBehaviour
{
    public float maxSpeed = 20f; // Velocidad máxima
    public float minSpeed = -20f; // Velocidad minima
    public float acceleration = 5f; // Aceleración
    public float deceleration = 10f; // Deceleración
    public float turnSpeed = 25f; // Velocidad de giro
    public float horsepower = 150f; // Caballos de fuerza

    private float currentSpeed = 0f; // Velocidad actual

    void Update()
    {
        // Obtener la entrada vertical
        float input = Input.GetAxis("Vertical");

        // Calcular la aceleración o deceleración
        if (input > 0)
        {
            currentSpeed += acceleration * Time.deltaTime;
        }
        else if (input < 0)
        {
            currentSpeed -= deceleration * Time.deltaTime;
        }

        // Limitar la velocidad máxima
        currentSpeed = Mathf.Clamp(currentSpeed, -maxSpeed, maxSpeed);
        

        // Movimiento del coche
        transform.Translate(0, 0, currentSpeed * Time.deltaTime);

        // Giro del coche
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, turn, 0);
    }
}

