using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamblingManager : MonoBehaviour
{
    public int Espacio1 = 0;
    public TextMeshProUGUI TextEspacio1;
    public int Espacio2 = 0;
    public TextMeshProUGUI TextEspacio2;
    public int Espacio3 = 0;
    public TextMeshProUGUI TextEspacio3;
    public int Espacio4 = 0;
    public TextMeshProUGUI TextEspacio4;
    public int EspacioR = 0;
    public TextMeshProUGUI TextEspacioR;
    public int EspacioN = 0;
    public TextMeshProUGUI TextEspacioN;

    private int TotalGanadoRonda = 0;

    public bool Gambleando = false;

    public Casilla CasillaSeleccionada = Casilla.Ninguno;

    void Update()
    {
        TextEspacio1.text = Espacio1.ToString();
        TextEspacio2.text = Espacio2.ToString();
        TextEspacio3.text = Espacio3.ToString();
        TextEspacio4.text = Espacio4.ToString();
        TextEspacioR.text = EspacioR.ToString();
        TextEspacioN.text = EspacioN.ToString();
    }

    // Ruleta
    public float rotationDuration = 3f;
    private float rotationSpeed = 2000f;
    private float[] targetAngles = { 45f, 135f, 225f, 315f };
    public FlechaRuletaScript FlechaScript;

    public void SumarEspacio(Casilla casilla, int suma)
    {
        switch (casilla)
        {
            case Casilla.Casilla1:
                Espacio1 += suma;
                break;
            case Casilla.Casilla2:
                Espacio2 += suma;
                break;
            case Casilla.Casilla3:
                Espacio3 += suma;
                break;
            case Casilla.Casilla4:
                Espacio4 += suma;
                break;
            case Casilla.CasillaN:
                EspacioN += suma;
                break;
            case Casilla.CasillaR:
                EspacioR += suma;
                break;
        }
    }


    public void Gambling()
    {
        StartCoroutine(RotateForSeconds(rotationDuration));
    }

    IEnumerator RotateForSeconds(float duration)
    {
        Gambleando = true;
        float elapsedTime = 0f;
        duration += Random.value;
        while (elapsedTime < duration)
        {
            FlechaScript.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        SnapToClosestAngle();
        Gambleando = false;
    }

    void SnapToClosestAngle()
    {
        float currentAngle = FlechaScript.transform.eulerAngles.z;

        float closestAngle = targetAngles[0];
        float minDifference = Mathf.Abs(Mathf.DeltaAngle(currentAngle, targetAngles[0]));

        for (int i = 1; i < targetAngles.Length; i++)
        {
            float difference = Mathf.Abs(Mathf.DeltaAngle(currentAngle, targetAngles[i]));
            if (difference < minDifference)
            {
                minDifference = difference;
                closestAngle = targetAngles[i];
            }
        }
        FlechaScript.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, closestAngle);
        CalcularGabling(closestAngle);
    }

    void CalcularGabling(float angulo) 
    {
        switch (angulo) 
        {
            case 45f:
                
                TotalGanadoRonda = Espacio1 * 4 + EspacioN * 2;
                break;

            case 135f:
                TotalGanadoRonda = Espacio2 * 4 + EspacioR * 2;
                break;

            case 225f:
                TotalGanadoRonda = Espacio3 * 4 + EspacioN * 2;
                break;

            case 315f:
                TotalGanadoRonda = Espacio4 * 4 + EspacioR * 2;
                break;
        }
        SumarATotal();
        ResetValores();
    }

    void ResetValores() 
    {
        Espacio1 = 0;
        Espacio2 = 0;
        Espacio3 = 0;
        Espacio4 = 0;
        EspacioR = 0;
        EspacioN = 0;
        TotalGanadoRonda = 0;
        CasillaSeleccionada = Casilla.Ninguno;
    }

    void SumarATotal() 
    {
        print(TotalGanadoRonda);
    }
}

public enum Casilla
{
    Ninguno,
    Casilla1,
    Casilla2,
    Casilla3,
    Casilla4,
    CasillaR,
    CasillaN
}
