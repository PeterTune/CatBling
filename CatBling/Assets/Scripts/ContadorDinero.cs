using UnityEngine;
using TMPro;
using System.Collections;

public class CounterTMPro : MonoBehaviour
{
    public TMP_Text counterText; // Referencia al componente de texto TextMesh Pro en la UI
    private int counter = 1000; // Variable para llevar el conteo
    public VarManager Gato;
    private AudioSource audioSource; // Referencia al AudioSource

    void Start()
    {
        Gato.dinero = counter;
        // Inicializa el texto con el valor del contador
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Verifica si se presiona cualquier tecla
        if (Input.anyKeyDown && Gato.ubicacion == 1)
        {
            // Incrementa el contador
            Gato.dinero++;
            // Actualiza el texto del contador

            StartCoroutine(PlaySound());
        }
    }


    IEnumerator PlaySound()
    {
        // Reproduce el sonido asignado al AudioSource
        if (audioSource != null)
        {
            audioSource.Play();
        }
        yield return null;
    }
}
