using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float angularSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Transform t = transform;
        // t.position = Vector3.zero;
        Vector3 p = t.position;
        t.position = new Vector3(2, 3, 4);
        transform.position = new Vector3(6, 7, 8);

        Debug.Log("Height: " + transform.position.y);

        Vector3 pos = t.position;
        pos.y = 3;
        t.position = pos;
        */
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = GetInputDirection();

        if (direction!=Vector3.zero)
        {
            Vector3 velocity = direction * speed;
            transform.position += velocity * Time.deltaTime;

            Quaternion targetRot = Quaternion.LookRotation(direction);
            Quaternion currentRot = transform.rotation;

            float step = angularSpeed * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(currentRot, targetRot, step);
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

        Vector3 direction = new Vector3(x, 0, z);
        direction.Normalize(); // Normalizálni kell, keresztmozgásnál gyök2 a sebesség, ehelyett 1 lesz az érték.

        return direction;   
    }

}
