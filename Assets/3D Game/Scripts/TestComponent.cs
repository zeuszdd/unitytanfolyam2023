using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Direction { North, South, East, West }

[Serializable]
struct MyVector2
{
    public float x, y;
    public MyVector2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
}
public class TestComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 2;
        Direction myDirection = Direction.East;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
