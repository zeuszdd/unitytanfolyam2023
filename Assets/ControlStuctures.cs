using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStuctures : MonoBehaviour
{
    [SerializeField] int a, b;
    // Start is called before the first frame update
    void Start()
    {
        // Egyágú elágazás: if statement
        if (a > 12)
        {
            Debug.Log("A is higher then 12.");
        }

        // Ha egy elágazás valamely ága csak egy soros, a kapcsos zárójel kiírása opcionális

        // Kétágú elágazás: if-eles statement
        bool isEven = a % 2 == 0;
        if (isEven)
            Debug.Log("A is an even number.");
        else
            Debug.Log("A is an odd number.");

        // Feltételes értékadás a ?: operátorral
        // Logikai kifejezés ? (érték, ha igaz) : (érték, ha nem igaz)
        string parity = isEven ? "even" : "odd";
        Debug.Log($"A is an {parity} number.");

        // Többágú elágazás: else-if statement
        if (a > 0)
            Debug.Log("A is a positive number.");
        else if (a < 0)
            Debug.Log("A is negative number.");
        else
            Debug.Log("A and B equals");

        // Többágú elágazás: switch statement
        switch (a % 3)
        {
            case 0:
                Debug.Log("Divisible by 3");
                break; // ⚠️ break-et kötelező kiírni a switch minden ágában! ⚠️
            case 1:
                Debug.Log("Not divisible by Three. Remainder: One");
                break;
            default: // Opcionálisan adható a végén egy "egyébként" ág
                Debug.Log("Not divisible by Three. Remainder: Two");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
