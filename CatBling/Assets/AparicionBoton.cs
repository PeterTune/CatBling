using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionBoton : MonoBehaviour
{
    public GameObject boton;
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Boton(tiempo));  
    }

    IEnumerator Boton(float t)
    {
        yield return new WaitForSeconds(t);
        boton.SetActive(true);
    }
}
