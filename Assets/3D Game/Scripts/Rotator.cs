using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed = 360;
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
        // tengely �s mekkora sz�get fordul el
        transform.Rotate(axis, angularSpeed * Time.deltaTime, space);
    }

    void OnDrawGizmos()
    {
        if (space==Space.Self)
        {
            Gizmos.matrix = transform.localToWorldMatrix;
        }

        Vector3 center = space == Space.Self ? Vector3.zero : transform.position;

        Vector3 a = center + axis.normalized;
        Vector3 b = center - axis.normalized;

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(a, b);

        Gizmos.matrix = Matrix4x4.identity;
    }
}
