using UnityEngine;
using System.Collections;

public class YenManager : MonoBehaviour
{
    public float liftDuration = 0.5f; // Duración del movimiento hacia arriba
    public float liftSpeed = 1.0f; // Velocidad a la que el objeto se moverá hacia arriba

    private void Start()
    {
        StartCoroutine(LiftAndDestroy());
    }

    IEnumerator LiftAndDestroy()
    {
        float elapsedTime = 0f;

        while (elapsedTime < liftDuration)
        {
            // Mover el objeto hacia arriba
            gameObject.transform.Translate(Vector3.up * liftSpeed * Time.deltaTime);

            // Incrementar el tiempo transcurrido
            elapsedTime += Time.deltaTime;

            // Esperar al siguiente frame
            yield return null;
        }

        // Destruir el objeto
        Destroy(gameObject);
    }
}

