using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // Velocidad de rotaci�n en grados por segundo

    void Update()
    {
        // Calcular el �ngulo de rotaci�n basado en la velocidad y el tiempo transcurrido
        float rotationAngle = rotationSpeed * Time.deltaTime;

        // Rotar el objeto alrededor del eje Y
        transform.Rotate(0, rotationAngle, 0);
    }
}
