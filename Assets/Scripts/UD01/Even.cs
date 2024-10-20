using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
   
    private void Start()
    {
        string evenNumbers = "";
        for (int i = 0; i <= 100; i += 2)
        {
            evenNumbers += i + " ";
        }
        Debug.Log("Números pares: " + evenNumbers);
    }
}
