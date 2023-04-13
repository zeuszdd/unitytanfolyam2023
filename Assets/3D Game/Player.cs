using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
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
        Vector3 direction = Vector3.right;
        Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;
    }
    Vector3 GetInputDirection()
    {
        bool rightButton = Input.GetKey(KeyCode.RightArrow);
        bool leftButton = Input.GetKey(KeyCode.LeftArrow);
        bool upButton = Input.GetKey(KeyCode.UpArrow);
        bool downButton = Input.GetKey(KeyCode.DownArrow);

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
