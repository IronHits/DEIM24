using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Zona de variables globales
    public int num1;
    public int num2;
    public int num3;

    //Condiciones
    void Start()
    {
        if (num1 < num2 && num2 < num3)
        {
            Debug.Log("Los números están en orden ascendente.");
        }
        else
        {
            Debug.Log("Los números no están en orden ascendente.");
        }
    }
}
