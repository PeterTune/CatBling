using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptShop : MonoBehaviour
{
    public GameObject ObjetoLogic;
    public int PrecioObjA = 50;
    public int PrecioObjB = 30;
    public int PrecioObjC = 20;
    public int PrecioObjD = 1000000;

    public TMP_Text objA;
    public TMP_Text objB;
    public TMP_Text objC;
    public TMP_Text objD;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        objA.SetText("$" + PrecioObjA.ToString() + "\nPelota");
        objB.SetText("$" + PrecioObjB.ToString() + "\nComida");
        objC.SetText("$" + PrecioObjC.ToString() + "\nHierba");
        objD.SetText("$" + PrecioObjD.ToString() + "\nTrofeo");
    }
    public void ComprarObjeto(int ID_Objeto)
    {
        VarManager scriptA = ObjetoLogic.GetComponent<VarManager>();

        if (scriptA.ubicacion != 4)
        {
            return;
        }

        if (scriptA != null)
        {
            switch (ID_Objeto)
            {
                case 1:
                    if (scriptA.dinero >= PrecioObjA)
                    {
                        scriptA.restarDinero(PrecioObjA);
                        scriptA.sumarTrabajo(20);
                        PrecioObjA += PrecioObjA;
                    } else
                    {
                        Debug.Log("Te falta dinero");
                    }
                        
                    break;
                case 2:
                    if (scriptA.dinero >= PrecioObjB)
                    {
                        scriptA.restarDinero(PrecioObjB);
                        scriptA.sumarFamilia(20);
                        PrecioObjB += PrecioObjB;
                    }
                    else
                    {
                        Debug.Log("Te falta dinero");
                    }
                    break;
                case 3:
                    if (scriptA.dinero >= PrecioObjC)
                    {
                        scriptA.restarDinero(PrecioObjC);
                        scriptA.sumarFelicidad(20);
                        PrecioObjC += PrecioObjC;
                    }
                    else
                    {
                        Debug.Log("Te falta dinero");
                    }
                    break;
                case 4:
                    if(scriptA.dinero >= PrecioObjD)
                    {
                        scriptA.restarDinero(PrecioObjD);
                        
                    } 
                    else
                    {
                        Debug.Log("Te falta dinero");
                    }
                    break;
                default:
                    Debug.LogWarning("ID no reconocida: " + ID_Objeto);
                    break;
            }

            
        } else
        {
            Debug.LogError("ObjetoA no tiene el componente ScriptDeObjetoA adjuntado.");
        }

    }
}
