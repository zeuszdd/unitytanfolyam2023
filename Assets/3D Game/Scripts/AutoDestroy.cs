using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] float destroyDistance = 100;
    [SerializeField] float destroyTime = 100;

    Vector3 startPos;
    // float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        // startTime = Time.time;

        // Destroy(gameObject, destroyTime);   // Késleltetve
        
        Invoke(nameof(DestroySelf), destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        float currentDistance = Vector3.Distance(startPos, transform.position);
        if (currentDistance > destroyDistance) 
        {
            DestroySelf();
        }
    }

    void DestroySelf()
    {
        // ...
        Destroy(gameObject);
    }
}
