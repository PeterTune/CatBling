using UnityEngine;
using TMPro;

public class CounterTMPro : MonoBehaviour
{
    public TMP_Text counterText; // Referencia al componente de texto TextMesh Pro en la UI
    private int counter = 1000; // Variable para llevar el conteo
    public VarManager Gato;
    private AudioSource audioSource; // Referencia al AudioSource

    void Start()
    {
        // Inicializa el texto con el valor del contador
        UpdateCounterText();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Verifica si se presiona cualquier tecla
        if (Input.anyKeyDown && Gato.ubicacion == 1)
        {
            // Incrementa el contador
            counter++;
            // Actualiza el texto del contador
            UpdateCounterText();

            PlaySound();
        }
    }

    void UpdateCounterText()
    {
        // Actualiza el texto del componente de UI con el valor actual del contador
        Gato.dinero = counter;
    }

    void PlaySound()
    {
        // Reproduce el sonido asignado al AudioSource
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
