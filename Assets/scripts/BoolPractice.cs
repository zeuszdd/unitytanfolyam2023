using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool b1 = true;
        bool b2 = false;
        
        b1 = false;

        int i1 = 33;
        int i2 = 66;
        bool intsAreEqual = i1 == i2;

        bool s1 = "aaa" == "AAA"; // false

        int ammo = 50;
        bool isAlive = true;
        bool haveAmmo = ammo > 0;
        bool canShoot = isAlive && haveAmmo;
        float height = 12;
        bool canAirJump = false;
        bool canJump = canAirJump || height == 0; // false
        bool isInAir = height > 0;
        bool isGrounded = !isInAir;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
