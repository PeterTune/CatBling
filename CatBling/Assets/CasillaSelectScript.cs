using UnityEngine;

public class CasillaSelectScript : MonoBehaviour
{
    public GamblingManager manager;

    public Casilla Casilla;

    public void OnClick()
    {
        manager.CasillaSeleccionada = Casilla;
    }
}
