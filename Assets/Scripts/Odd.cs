using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
 
    private void Start()
    {
        string oddNumbers = "";
        for (int i = 1; i < 100; i += 2)
        {
            oddNumbers += i + " ";
        }
        Debug.Log("Números impares: " + oddNumbers);
    }
}
