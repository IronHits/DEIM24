using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    private void Start()
    {
        string multiplesOfThreeAndTwo = "";
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                multiplesOfThreeAndTwo += i + " ";
            }
        }
        Debug.Log("Multiplos de 3 y 2: " + multiplesOfThreeAndTwo);
    }
}
