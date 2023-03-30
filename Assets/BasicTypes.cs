using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTypes : MonoBehaviour
{
    [SerializeField] [Min(10)] int intField = 5;
    [SerializeField] [Range(0,10)] float floatField = 5.55f;
    [SerializeField] string stringField = "hello";
    [SerializeField] bool boolField = true;

    // Start is called before the first frame update
    void Start()
    {
        int i = 4;
        float f = 1.53f;
        string s = "my first string";
        bool b1 = true;
        bool b2 = false;
        var v1 = "string";
        var v2 = 12.5f;
        var v3 = false;
        float f1 = f + 4;
        float f2 = f1 - f;
        float f3 = f2 * f;
        float f4 = f2 / f;
        float f5 = f2 % f;
        float f6 = 3 / 2f;
        int i1 = 3, i2 = 2;
        float f7 = i1 / (float)i2;
        double d = 23.45678;
        long l = 123456;

        string s1 = s + " akármi";
        Debug.Log(s1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
