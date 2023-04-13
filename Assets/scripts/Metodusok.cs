using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodusok : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Azokat a MET�DUS-okat (METHOD), amiknek nincs visszat�r�si �rt�ke,
        // azaz void t�pus�ak, ELJ�R�S-oknak (ROUTINE) nevezz�k.

        void RoutineWithNoParameter()  // Elj�r�s param�terek n�lk�l
        {
            Debug.Log("Hello World!");
            // Nincs visszat�r�se, teh�t elj�r�s
            // Tesz valamit, de nem ad vissza semmit.
        }

        void Introduction(string name, int age)  // Elj�r�s param�terekkel
        {
            Debug.Log($"Hello! My name is {name},and I'm {age} years old.");
            // Nincs visszat�r�se, de vannak param�terei, azaz bemen� adatai.
        }

        // Kil�pni met�dusokb�l a void kulcssz�val tudunk
        // Ez az elj�r�s bemutatja a return kulcssz� haszn�lat�t void t�pus� met�dusokban:

        void IsPrime(int n)    // Ez az elj�r�s ki�rja egy term�szetes sz�mr�l, hogy pr�m-e
        {
            if (n < 0)          // Ha a sz�m negat�v, akkor nem kezelj�k 
            {
                Debug.Log("I don't know if negative numbers are prime or not.");
                return;        // A return kulcssz�val kil�phet�nk a met�dusb�l
            }

            // Megn�zz�k az �sszes sz�mot, 2 �s a bemeneti v�ltoz� k�zt:
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)  // Ha tal�lunk egy sz�mot ami oszt�ja a bemeneti sz�mnak,
                {
                    Debug.Log($"{n} is not a prime number."); // ki�rjuk, hogy nem pr�m,
                    return;      // �s kil�p�nk az elj�r�sb�l a return kulcssz�val
                }
            }

            // Egy oszt� sem tal�lhat�, ez�rt a bemeneti sz�m pr�m.
            Debug.Log($"{n} is a prime number.");
        }

        // Azokat a MET�DUS-okat (METHOD), amiknek van visszat�r�si �rt�ke,
        // azaz NEM void t�pus�ak, F�GGV�NY-eknek (FUNCTION) nevezz�k.

        int Sum(int a, int b)   // Ez a f�ggv�ny k�t term�szetes sz�m �sszeg�t adja vissza.
        {
            return a + b;       // A return kulcssz�val tudunk visszat�rni a met�dusb�l
                                // Minden f�ggv�nynek van visszat�r�si �rt�ke,
                                // ez�rt a return kulcssz� k�telez�
        }

        string IsEven(int n)    // Ez a f�ggv�ny megmondja, hogy egy term�szetes sz�m p�ros-e.
        {
            // Egy f�ggv�ny t�bb ponton is tud visszat�rni.
            if (n % 2 == 0)      // Ha a sz�m oszthat� 2-vel,
                return "Even";  // visszat�r�nk a met�dusb�l a "Even" �rt�kkel,
            else                // k�l�nben
                return "Odd";   // visszat�r�nk a met�dusb�l az "Odd" �rt�kkel.
        }

        // C#-ben a v�ltoz�k neve mindig kezd�dj�n kisbet�vel!
        // C#-ben a met�dusok neve mindig kezd�dj�n nagybet�vel!

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
