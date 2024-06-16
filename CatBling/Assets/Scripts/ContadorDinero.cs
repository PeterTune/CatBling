using UnityEngine;
using TMPro;
using System.Collections;

public class CounterTMPro : MonoBehaviour
{
    public TMP_Text counterText; // Referencia al componente de texto TextMesh Pro en la UI
    private int counter = 1000; // Variable para llevar el conteo
    public VarManager Gato;
    public GameObject coinSound;
    private bool sonidoMoneda = false;

    void Start()
    {
        Gato.dinero = counter;
    }

    void Update()
    {
        // Verifica si se presiona cualquier tecla
        if (Input.anyKeyDown && Gato.ubicacion == 1)
        {
            // Incrementa el contador
            Gato.dinero++;
            // Actualiza el texto del contador

            if(sonidoMoneda == false)
            {
                sonidoMoneda = true;
                Instantiate(coinSound);
                StartCoroutine(TimeCoin(0.1f));
            }
            
        }
    }

    IEnumerator TimeCoin (float t)
    {
        yield return new WaitForSeconds(t);
        sonidoMoneda = false;
    }

}
