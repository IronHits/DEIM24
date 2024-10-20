using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    
    private void Start()
    {
        string multiplesOfThree = "";
        for (int i = 0; i <= 100; i += 3)
        {
            multiplesOfThree += i + " ";
        }
        Debug.Log("Multiplos de 3: " + multiplesOfThree);
    }
}
