using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ScriptShop : MonoBehaviour
{
    public GameObject ObjetoLogic;
    public int PrecioObjA = 50;
    public int PrecioObjB = 30;
    public int PrecioObjC = 20;




    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ComprarObjeto(int ID_Objeto)
    {
        VarManager scriptA = ObjetoLogic.GetComponent<VarManager>();

        

        if (scriptA != null)
        {
            switch (ID_Objeto)
            {
                case 1:
                    if (scriptA.dinero >= PrecioObjA)
                    {
                        scriptA.restarDinero(PrecioObjA);
                        scriptA.sumarFamilia(50);
                    } else
                    {
                        Debug.Log("Te falta dinero");
                    }
                        
                    break;
                case 2:
                    if (scriptA.dinero >= PrecioObjB)
                    {
                        scriptA.restarDinero(PrecioObjB);
                        scriptA.sumarFelicidad(50);
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
                        scriptA.sumarTrabajo(50);
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
