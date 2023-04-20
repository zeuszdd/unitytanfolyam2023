using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPoint = target.position;
        Vector3 selfPoint = transform.position;
        transform.position = Vector3.MoveTowards(selfPoint, targetPoint, speed * Time.deltaTime);
    }
}
