using UnityEngine;

public class CasillaSelectScript : MonoBehaviour
{
    public GamblingManager manager;
    public SpriteRenderer spriteRenderer;

    public Casilla Casilla;

    private void Update()
    {
        if (manager.CasillaSeleccionada == Casilla) 
        {
            spriteRenderer.enabled = true;
        }
        else 
        {
            spriteRenderer.enabled = false;
        }
    }

    public void OnClick()
    {
        manager.CasillaSeleccionada = Casilla;
    }
}
