using UnityEngine;

public class ClickDinero : MonoBehaviour
{
    public int valor;

    public GamblingManager GamblingManager;
    public VarManager Gato;

    public Casilla CasillaElegida; 

    public void OnClick()
    {
        CasillaElegida = GamblingManager.CasillaSeleccionada;
        if (Gato.dinero >= valor && CasillaElegida != Casilla.Ninguno)
        {
            Gato.dinero -= valor;
            GamblingManager.SumarEspacio(CasillaElegida, valor);
        }
    }
}
