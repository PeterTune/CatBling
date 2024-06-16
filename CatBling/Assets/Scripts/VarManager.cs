using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
    public GameObject Botones;
    public GameObject GUI;

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

        if (ubicacion == 0)
        {
            if(!haveFelicidad)
            {
                SceneManager.LoadScene("SinFelicidad");
            }

            if(!haveDinero)
            {
                SceneManager.LoadScene("SinDinero");
            }

            if(!haveFamilia)
            {
                SceneManager.LoadScene("SinFamilia");
            }

            if(!haveTrabajo && haveFamilia)
            {
                SceneManager.LoadScene("SinTrabajo");
            }


        }
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
        if (valor > 0 )
        {
            haveDinero = true;
        }
            
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
        sumarEdad();
        ubicacion = 3;
        Vector2 nuevaPosicion = referenciaCasa.transform.position;
        transform.position = nuevaPosicion;
        //funciones a realizar:
        sumarFamilia(10);
        restarFelicidad(10);
        Invoke("IrMenu", 5.0f);
    }
    public void IrTrabajo()
    {
        sumarEdad();
        ubicacion = 1;
        Vector2 nuevaPosicion = referenciaTrabajo.transform.position;
        transform.position = nuevaPosicion;
        //funciones a realizar:
        restarFelicidad(5);
        sumarTrabajo(10);
        Invoke("IrMenu", 7.0f);
    }
    public void IrCasino()
    {
        GUI.SetActive(true);
        sumarEdad();
        ubicacion = 2;
        Vector2 nuevaPosicion = referenciaCasino.transform.position;
        transform.position = nuevaPosicion;
        //funciones a realizar:
        restarFamilia(10);
        sumarFelicidad(10);
        restarTrabajo(10);
    }
    public void IrTienda()
    {
        GUI.SetActive(true);
        ubicacion = 4;
        Vector2 nuevaPosicion = referenciaTienda.transform.position;
        transform.position = nuevaPosicion;
        //funciones a realizar:
    }
    public void IrMenu()
    {
        GUI.SetActive(false);
        ubicacion = 0;
        Botones.SetActive(true);
    }
}
