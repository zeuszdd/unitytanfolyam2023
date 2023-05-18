using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] KeyCode shootKey = KeyCode.Space;
    [SerializeField] GameObject projectilePrototype;
    [SerializeField] float projectileSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shootKey)) 
        {
            // Shoot
            GameObject newBullet = Instantiate(projectilePrototype);
            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = Quaternion.LookRotation(transform.up);
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();

            rb.velocity = transform.up * projectileSpeed;
        }
    }
}
