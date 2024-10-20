using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    //Zona de variables globales
    public int monthNumber;

    void Start()
    {
        if (monthNumber >= 1 && monthNumber <= 12)
        {
            string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Debug.Log("El mes es: " + months[monthNumber - 1]);
        }
        else
        {
            Debug.Log("Introducir número entre el 1 y el 12.");
        }
    }
}
