using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] float[] testArray;
    [SerializeField] float mean;
    [SerializeField] float max;

    void OnValidate()
    {
        /*
        float mean1 = Mean(2, 6);
        float mean2 = Mean(2, 6, 7);

        float[] a1 = new float[] { 1, 3, 5, 7 };
        float mean3 = Mean(a1);
        Debug.Log(mean3);

        float[] array1 = new float[10];

        array1[0] = 0.55f;
        array1[1] = 1.53f;
        array1[2] = 2.95f;

        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = i;
        }

        string[] array2 = new string[] { "Alma", "Körte", "Banán" };
        int[] array3= new int[] {1,2,3,4,5};

        Debug.Log(array2[1]);
        Debug.Log(array2[3]); // ERROR
        */
        List<int> list1 = new List<int>();
        list1.Add(201);
        list1.Add(21);
        list1.Add(12201);

        Debug.Log(list1[0]);
        list1[1]= 10;

        list1.Add(12201);
        list1[10] = 76;

        list1.RemoveAt(1);
        list1.Remove(12201);

        list1.Insert(0, 21123);

        

    }

    float Mean(float n1, float n2)
    {
        return (n1 + n2) / 2;
    }

    float Mean(float n1, float n2, float n3)
    {
        return (n1 + n2 + n3) / 3;
    }

    float Mean(float[] array)
    {
        float sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            float current = array[i];
            sum += current;
        }
        return sum / array.Length;
    }

    float Max (params float[] array)
    {
        if (array.Length==0)
        {
            return 0;
        }
        float max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            float current = array[i];
            if (current > max)
                max = current;
        }
        return max;
    }

    float Min(params float[] array)
    {
        float min = array[0];
        foreach (int f in array)
        {
            if (f < min)
            {
                min = f;
            }
        }
        return min;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
