using UnityEngine;

public class ClickDinero : MonoBehaviour
{
    public int valor;

    public GamblingManager GamblingManager;

    public Casilla CasillaElegida; 

    public void OnClick()
    {
        CasillaElegida = GamblingManager.CasillaSeleccionada;
        GamblingManager.SumarEspacio(CasillaElegida, valor);
    }
}
