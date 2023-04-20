using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    [SerializeField] Space space;
    [SerializeField] Vector3 axis = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 axis = Vector3.up;
        // tengely és mekkora szöget fordul el
        transform.Rotate(axis, angularSpeed * Time.deltaTime, space);
    }

    void OnDrawGizmos()
    {
        Vector3 center= transform.position;
        Vector3 a = center + axis.normalized;
        Vector3 b = center - axis.normalized;

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(a, b);
        
    }
}
