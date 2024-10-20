using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Zona de variables globales
    public int num1;
    public int num2;
    public int num3;

    void Start()
    {
        int[] numbers = { num1, num2, num3 };
        System.Array.Sort(numbers);
        Debug.Log("Números de menor a mayor: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
    }
}
