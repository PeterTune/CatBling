using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    public GameObject Gato;
    public GameObject referenciaCasa;
    public GameObject referenciaTrabajo;
    public GameObject referenciaCasino;
    public GameObject referenciaTienda;

    public void IrCasa() 
    {
        Vector2 nuevaPosicion = referenciaCasa.transform.position;
        transform.position = nuevaPosicion;
    }
    public void IrTrabajo() 
    {
        Vector2 nuevaPosicion = referenciaTrabajo.transform.position;
        transform.position = nuevaPosicion;
    }
    public void IrCasino() 
    {
        Vector2 nuevaPosicion = referenciaCasino.transform.position;
        transform.position = nuevaPosicion;
    }
    public void IrTienda() 
    {
        Vector2 nuevaPosicion = referenciaTienda.transform.position;
        transform.position = nuevaPosicion;
    }

}
