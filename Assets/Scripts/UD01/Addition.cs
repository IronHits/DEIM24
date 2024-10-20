using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    //Zona de variables globales
    public int inputNumber;

    private void Start()
    {
        int sum = 0;
        for (int i = 1; i <= inputNumber; i++)
        {
            sum += i;
        }
        Debug.Log("La suma de " + inputNumber + ": " + sum);
    }
}
