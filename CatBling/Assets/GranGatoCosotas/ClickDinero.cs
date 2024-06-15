using UnityEngine;

public class ClickDinero : MonoBehaviour
{
    public int total;
    public int valor;
    public bool contado;
    public bool Mitad;
    public bool AllIn;

    public void OnClick()
    {
        Debug.Log("Objeto clicado: " + gameObject.name);
    }
}
