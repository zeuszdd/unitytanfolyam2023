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
        // Elöltesztelõ ciklus: while loop
        int num = 0;
        while (num < 100)               // A ciklus elején van a kilépési feltétel
        {
            num += num;
        }

        // Hátultesztelõ ciklus: do-while loop
        num = 0;
        do                        // A ciklus törzse legalább egyszer biztos lefut.
        {
            num += num;
        }
        while (num < 100);          // A ciklus hátujánál van a kilépési feltétel

        // Számláló ciklus: for loop
        for (int i = 0; i < 10; i++)    // A for elöltesztelõ: Elõl van a kilépési feltétel
        {                                                               // Van egy ciklusváltozója. Itt most: i
            Debug.Log(i * i);
        }

        // Iteráló ciklus: foreach loop
        foreach (char ch in "ABCDEFG")  // Végiglépeget bizonyos típusok minden elemén
        {                                                               // Pl.: Tömb, List, string
            Debug.Log(ch);
        }

        int x = 1;
        int count = 0;
        while (count < 100)               // Kíirja az elsõ 100 elemet, amely osztható 3-al, VAGY 7-el.
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
