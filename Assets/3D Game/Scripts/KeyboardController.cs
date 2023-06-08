using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class KeyboardController : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float angularSpeed = 180f;
    [SerializeField] Transform cameraTransform;
    [SerializeField] bool moveInCameraSpace = true;

    [SerializeField] Damageable damageable;
    [SerializeField] Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnValidate()
    {
        if (damageable == null)
        {
            damageable = GetComponent<Damageable>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (damageable!=null&&!damageable.IsAlive()) 
        {
            return;
        }
        Vector3 direction = GetInputDirection();

        if (direction!=Vector3.zero)
        {
            Vector3 velocity = direction * speed;
            rigidBody.MovePosition(rigidBody.position + velocity * Time.deltaTime);

            Quaternion targetRot = Quaternion.LookRotation(direction);
            Quaternion currentRot = transform.rotation;

            float step = angularSpeed * Time.deltaTime;
            rigidBody.rotation = Quaternion.RotateTowards(currentRot, targetRot, step);
            //transform.rotation = Quaternion.LookRotation(direction);

        }
        
    }
    Vector3 GetInputDirection()
    {
        bool rightButton = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool leftButton = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool upButton = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool downButton = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);

        float x = 0;
        if (rightButton)
        {
            x += 1;
        }
        if (leftButton)
        {
            x -= 1;
        }

        float z = 0;
        if (upButton)
        {
            z += 1;
        }
        if (downButton)
        {
            z -= 1;
        }

        Vector3 cameraRight = cameraTransform.right;
        Vector3 cameraForward = cameraTransform.forward;

        // Vector3 direction = new Vector3(x, 0, z); glob�lis t�rben
        Vector3 d = x * cameraRight + z * cameraForward;
        d.y = 0;

        d.Normalize(); // Normaliz�lni kell, keresztmozg�sn�l gy�k2 a sebess�g, ehelyett 1 lesz az �rt�k.

        return d;   
    }

}
