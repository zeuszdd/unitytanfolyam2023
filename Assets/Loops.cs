using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // El�ltesztel� ciklus: while loop
        int num = 0;
        while (num < 100)               // A ciklus elej�n van a kil�p�si felt�tel
        {
            num += num;
        }

        // H�tultesztel� ciklus: do-while loop
        num = 0;
        do                        // A ciklus t�rzse legal�bb egyszer biztos lefut.
        {
            num += num;
        }
        while (num < 100);          // A ciklus h�tuj�n�l van a kil�p�si felt�tel

        // Sz�ml�l� ciklus: for loop
        for (int i = 0; i < 10; i++)    // A for el�ltesztel�: El�l van a kil�p�si felt�tel
        {                                                               // Van egy ciklusv�ltoz�ja. Itt most: i
            Debug.Log(i * i);
        }

        // Iter�l� ciklus: foreach loop
        foreach (char ch in "ABCDEFG")  // V�gigl�peget bizonyos t�pusok minden elem�n
        {                                                               // Pl.: T�mb, List, string
            Debug.Log(ch);
        }

        int x = 1;
        int count = 0;
        while (count < 100)               // K�irja az els� 100 elemet, amely oszthat� 3-al, VAGY 7-el.
        {
            if (x % 3 == 0 || x % 7 == 0)
            {
                Debug.Log(x);
                count++;
            }
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
