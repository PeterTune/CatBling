using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamaras : MonoBehaviour
{
    public VarManager controlador;
    public Animator camarasAnimator;
    // Start is called before the first frame update
    void Start()
    {
        camarasAnimator.SetInteger("ubicacion", 0);
    }

    // Update is called once per frame
    void Update()
    {
        camarasAnimator.SetInteger("ubicacion", controlador.ubicacion);
    }
}
