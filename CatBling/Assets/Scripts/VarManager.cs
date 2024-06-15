using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class VarManager : MonoBehaviour
{
    public int edad = 30;
    public int dinero = 1000;
    public int felicidad = 100;
    public int familia = 100;
    public int trabajo = 100;

    public bool haveEdad = true;
    public bool haveDinero = true;
    public bool haveFelicidad = true;
    public bool haveFamilia = true;
    public bool haveTrabajo = true;
    
    //Variables para mover jugador a referencias
    public GameObject Gato;
    public GameObject referenciaCasa;
    public GameObject referenciaTrabajo;
    public GameObject referenciaCasino;
    public GameObject referenciaTienda;

    //Variables
    public TMP_Text TMPfelicidad;
    public TMP_Text TMPtrabajo;
    public TMP_Text TMPfamilia;
    public TMP_Text TMPinero;

    // 1 = trabajo; 2 = casino; 3 = familia; 4 = tienda; 0 = menú;
    public int ubicacion = 0; 

    // Start is called before the first frame update
    void Start()
    {
        felicidad = 100;
        trabajo = 100;
        familia = 100;
        dinero = 1000;
        edad = 30;
    }

    // Update is called once per frame
    void Update()
    {
        TMPfelicidad.SetText("Felicidad: " + felicidad.ToString());
        TMPtrabajo.SetText("Trabajo: " + trabajo.ToString());
        TMPfamilia.SetText("Familia: " + familia.ToString());
        TMPinero.SetText("Dinero: $" + dinero.ToString());
    }

    public void restarEdad(int valor)
    {
        edad -= valor;
    }

    public void restarDinero(int valor)
    {
        dinero -= valor;
        if (dinero <= 0)
        {
            haveDinero = false;
        }
    }

    public void restarFelicidad(int valor)
    {
        felicidad -= valor;
        if (felicidad <= 0)
        {
            haveFelicidad = false;
        }
    }

    public void restarFamilia(int valor)
    {
        familia -= valor;
        if (familia <= 0)
        {
            haveFamilia = false;
        }
    }    

    public void restarTrabajo(int valor)
    {
        trabajo -= valor;
        if (trabajo <= 0)
        {
            haveTrabajo = false;
        }
    }

    public void sumarEdad()
    {
        edad += 1;
        if (edad > 100)
        {
            haveEdad = false;
        }
    }

    public void sumarDinero(int valor)
    {
        dinero += valor;
    }

    public void sumarFelicidad(int valor)
    {
        felicidad += valor;
        if (felicidad > 100)
        {
            felicidad = 100;
        }
    }

    public void sumarFamilia(int valor)
    {
        familia += valor;
        if (familia > 100)
        {
            familia = 100;
        }
    }

    public void sumarTrabajo(int valor)
    {
        trabajo += valor;
        if (trabajo > 100)
        {
            trabajo = 100;
        }
    }


    //Funciones al apretar botones
    public void IrCasa()
    {
        ubicacion = 2;
        Vector2 nuevaPosicion = referenciaCasa.transform.position;
        transform.position = nuevaPosicion;
        //funciones a realizar:
        sumarDinero(10);
        sumarFelicidad(10);
    }
    public void IrTrabajo()
    {
        ubicacion = 0;
        Vector2 nuevaPosicion = referenciaTrabajo.transform.position;
        transform.position = nuevaPosicion;
        //funciones a realizar:
        sumarDinero(10);
        sumarTrabajo(10);
    }
    public void IrCasino()
    {
        ubicacion = 1;
        Vector2 nuevaPosicion = referenciaCasino.transform.position;
        transform.position = nuevaPosicion;
        //funciones a realizar:
        sumarDinero(10);
        restarFamilia(10);
    }
    public void IrTienda()
    {
        ubicacion = 3;
        Vector2 nuevaPosicion = referenciaTienda.transform.position;
        transform.position = nuevaPosicion;
        //funciones a realizar:
        sumarDinero(10);
    }
    public void IrMenu()
    {
        ubicacion = 4;
    }
}
