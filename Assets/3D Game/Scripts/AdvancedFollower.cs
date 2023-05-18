using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedFollower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float maxSpeed;
    [SerializeField] float maxDistance;
    [SerializeField] AnimationCurve distanceToSpeedCurve;
    [SerializeField] Gradient gradient;
    [SerializeField] Light light;

    float originalIntansity;
    // Start is called before the first frame update
    void Start()
    {
        originalIntansity = light.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = transform.position;
        Vector3 t = target.position;

        float distance = Vector3.Distance(p, t);

        float x = distance / maxDistance;
        float speed = distanceToSpeedCurve.Evaluate(x) * maxSpeed;
        Color c = gradient.Evaluate(x);
        light.color = c;
        light.intensity = c.a * originalIntansity;

        transform.position = Vector3.MoveTowards(p, t, speed * Time.deltaTime);
    }
}
