using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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

    // 0 = trabajo; 1 = casino; 2 = familia; 3 = tienda; 4 = menú;
    public int ubicacion = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
