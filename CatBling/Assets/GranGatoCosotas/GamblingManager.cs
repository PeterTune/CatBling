using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamblingManager : MonoBehaviour
{
    public int Boton1 = 0;
    public int Boton10 = 0;
    public int Boton100 = 0;
    public int Boton1k = 0;
    public int Boton10k = 0;
    public int BotonMitad = 0;
    public int BotonAllIn = 0;

    public int TotalGanadoRonda = 0;

    public bool Gambleando = false;

    // Ruleta
    public float rotationDuration = 3f;
    public float rotationSpeed = 90f;
    private float[] targetAngles = { 45f, 135f, 225f, 315f };

    void Gambling()
    {
        StartCoroutine(RotateForSeconds(rotationDuration));
    }

    IEnumerator RotateForSeconds(float duration)
    {
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            // Rotar el objeto alrededor del eje Z (ajustar según sea necesario)
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);

            // Incrementar el tiempo transcurrido
            elapsedTime += Time.deltaTime;

            // Esperar al siguiente frame
            yield return null;
        }

        // Ajustar el ángulo a uno de los ángulos específicos
        SnapToClosestAngle();
    }

    void SnapToClosestAngle()
    {
        // Obtener el ángulo actual del objeto en el eje Z
        float currentAngle = transform.eulerAngles.z;

        // Encontrar el ángulo más cercano en el array de ángulos objetivo
        float closestAngle = targetAngles[0];
        float minDifference = Mathf.Abs(Mathf.DeltaAngle(currentAngle, targetAngles[0]));

        for (int i = 1; i < targetAngles.Length; i++)
        {
            float difference = Mathf.Abs(Mathf.DeltaAngle(currentAngle, targetAngles[i]));
            if (difference < minDifference)
            {
                minDifference = difference;
                closestAngle = targetAngles[i];
            }
        }

        // Ajustar el ángulo del objeto al ángulo más cercano
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, closestAngle);
    }

}
