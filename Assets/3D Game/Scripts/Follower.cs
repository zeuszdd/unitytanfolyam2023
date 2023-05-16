using System.Drawing;
using System;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;
    [SerializeField] float bigRange=15;
    [SerializeField] float smallRange=10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPoint = target.position;
        Vector3 selfPoint = transform.position;
        float distance = Vector3.Distance(selfPoint, targetPoint);
        if (distance<=bigRange)
        {
            float t = Mathf.InverseLerp(bigRange, smallRange, distance);
            float actualSpeed = Mathf.Lerp(0, speed, t);

            transform.position = Vector3.MoveTowards(selfPoint, targetPoint, actialSpeed * Time.deltaTime);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(TransformBlock.position, smallRange);
        Gizmos.DrawWireSphere(TransformBlock.position, bigRange);
    }
}
