using System.Security.Cryptography;
using System.IO.Enumeration;
using System.Collections.Specialized;
using System.Threading.Tasks.Dataflow;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 targetOffset;

    [SerializeField] bool enableVerticalTurn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPoint = target.position + targetOffset;
        Vector3 selfPoint = transform.position;
        Vector3 dir = targetPoint - selfPoint;

        if (dir == Vector3.zero)
        {
            return;
        }

        if (!enableVerticalTurn)
        {
            float verticalAngle = transform.eulerAngles.x;
            dir.y = 0;
            if (dir == Vector3.zero)
            {
                return;
            }
            Vector3 euler = Quaternion.LookRotation(dir).eulerAngles;
            euler.x=verticalAngle;

            transform.rotation = Quaternion.Euler(euler);
        }
        else
        {
            transform.rotation = Quaternion.LookRotation(dir);
        }

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
        }
    }
}
