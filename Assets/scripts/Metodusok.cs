using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodusok : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Azokat a METÓDUS-okat (METHOD), amiknek nincs visszatérési értéke,
        // azaz void típusúak, ELJÁRÁS-oknak (ROUTINE) nevezzük.

        void RoutineWithNoParameter()  // Eljárás paraméterek nélkül
        {
            Debug.Log("Hello World!");
            // Nincs visszatérése, tehát eljárás
            // Tesz valamit, de nem ad vissza semmit.
        }

        void Introduction(string name, int age)  // Eljárás paraméterekkel
        {
            Debug.Log($"Hello! My name is {name},and I'm {age} years old.");
            // Nincs visszatérése, de vannak paraméterei, azaz bemenõ adatai.
        }

        // Kilépni metódusokból a void kulcsszóval tudunk
        // Ez az eljárás bemutatja a return kulcsszó használatát void típusú metódusokban:

        void IsPrime(int n)    // Ez az eljárás kiírja egy természetes számról, hogy prím-e
        {
            if (n < 0)          // Ha a szám negatív, akkor nem kezeljük 
            {
                Debug.Log("I don't know if negative numbers are prime or not.");
                return;        // A return kulcsszóval kiléphetünk a metódusból
            }

            // Megnézzük az összes számot, 2 és a bemeneti változó közt:
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)  // Ha találunk egy számot ami osztója a bemeneti számnak,
                {
                    Debug.Log($"{n} is not a prime number."); // kiírjuk, hogy nem prím,
                    return;      // és kilépünk az eljárásból a return kulcsszóval
                }
            }

            // Egy osztó sem található, ezért a bemeneti szám prím.
            Debug.Log($"{n} is a prime number.");
        }

        // Azokat a METÓDUS-okat (METHOD), amiknek van visszatérési értéke,
        // azaz NEM void típusúak, FÜGGVÉNY-eknek (FUNCTION) nevezzük.

        int Sum(int a, int b)   // Ez a függvény két természetes szám összegét adja vissza.
        {
            return a + b;       // A return kulcsszóval tudunk visszatérni a metódusból
                                // Minden függvénynek van visszatérési értéke,
                                // ezért a return kulcsszó kötelezõ
        }

        string IsEven(int n)    // Ez a függvény megmondja, hogy egy természetes szám páros-e.
        {
            // Egy függvény több ponton is tud visszatérni.
            if (n % 2 == 0)      // Ha a szám osztható 2-vel,
                return "Even";  // visszatérünk a metódusból a "Even" értékkel,
            else                // különben
                return "Odd";   // visszatérünk a metódusból az "Odd" értékkel.
        }

        // C#-ben a változók neve mindig kezdõdjön kisbetûvel!
        // C#-ben a metódusok neve mindig kezdõdjön nagybetûvel!

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
