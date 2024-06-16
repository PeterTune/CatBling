using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    public int ubicacion;
    public VarManager Gato;
    public bool enUbicacion = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gato.ubicacion == ubicacion && enUbicacion == false)
        {
            enUbicacion = true;
            audioSource.Play();
        }
        else if (Gato.ubicacion != ubicacion)
        {
            audioSource.Stop();
            enUbicacion = false;
        }
    }
}
