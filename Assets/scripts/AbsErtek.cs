using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsErtek : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = -45;
        int abs = Mathf.Abs(a);
        int min = Mathf.Min(a, 10);
        int max = Mathf.Max(a, 10, -5, 4);
        int MyAbs(int a)
        {
            int myAbs;
            if (a < 0)
            {
                myAbs = -a;
            }
            else
            {
                myAbs = a;
            }
            return myAbs;
        }
        float MyPow(float baseNumber, int exponent)
        {
            float result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result += baseNumber;
            }
            return result;
        }

        float power = Mathf.Pow(23.5f, 4.5f);
        float power2 = MyPow(23, (int)4.5f);

        // Elõjelek
        float MySign(float number)
        {
            if (number < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        // Szorzótábla
        void MultiplicationTable(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    string s = $"{j} * {i} = {i * j}";
                    Debug.Log(s);
                }
            }
        }

        MultiplicationTable(10);

        float f;
        f = Mathf.Clamp(power, -10, 10);
        f = Mathf.Clamp01(power2);
        f = Mathf.Ceil(f);
        f = Mathf.Floor(f);
        f = Mathf.Round(f);
        f = Mathf.CeilToInt(f);
        f = Mathf.FloorToInt(f);
        f = Mathf.RoundToInt(f);
        f = Mathf.Pow(f, 5);
        f = Mathf.Sqrt(f);
        // Köbgyök
        f = Mathf.Pow(f, 1/3f);

        f = Mathf.Ceil(f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
