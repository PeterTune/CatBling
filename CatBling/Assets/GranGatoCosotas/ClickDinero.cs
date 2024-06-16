using UnityEngine;

public class ClickDinero : MonoBehaviour
{
    public int valor;

    public GamblingManager GamblingManager;
    public VarManager Gato;

    public TipoClick tipoClick;
    public Casilla CasillaElegida; 

    public void OnClick()
    {
        if (tipoClick == TipoClick.Mitad)
            valor = Gato.dinero / 2;

        if (tipoClick == TipoClick.AllIn)
            valor = Gato.dinero;



        CasillaElegida = GamblingManager.CasillaSeleccionada;
        if (Gato.dinero >= valor && CasillaElegida != Casilla.Ninguno)
        {
            Gato.dinero -= valor;
            GamblingManager.SumarEspacio(CasillaElegida, valor);
        }
    }
}

public enum TipoClick
{
    Valor,
    Mitad,
    AllIn
}
