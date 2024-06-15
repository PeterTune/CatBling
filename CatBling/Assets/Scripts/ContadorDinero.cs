using UnityEngine;
using TMPro;

public class CounterTMPro : MonoBehaviour
{
    public TMP_Text counterText; // Referencia al componente de texto TextMesh Pro en la UI
    private int counter = 1000; // Variable para llevar el conteo

    void Start()
    {
        // Inicializa el texto con el valor del contador
        UpdateCounterText();
    }

    void Update()
    {
        // Verifica si se presiona cualquier tecla
        if (Input.anyKeyDown)
        {
            // Incrementa el contador
            counter++;
            // Actualiza el texto del contador
            UpdateCounterText();
        }
    }

    void UpdateCounterText()
    {
        // Actualiza el texto del componente de UI con el valor actual del contador
        counterText.text = "$"+counter.ToString();
    }
}
