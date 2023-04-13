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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
