using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Vektorok létrehozása:
        Vector3 v3D1 = new Vector3();           // X=0, Y=0, Z=0
        Vector3 v3D2 = new Vector3(1, 2);       // Z=0
        Vector3 v3D3 = new Vector3(1, 2, 3);

        Vector2 v2D1 = new Vector2();           // X=0, Y=0
        Vector2 v2D2 = new Vector2(1, 2);

        // Vektorok castolása:
        Vector3 v3D4 = v2D1;                    // Vector2 -> Vector3 (implicit cast)
        Vector2 v2D3 = v3D1;                    // Vector3 -> Vector2 (implicit cast)

        // Innentõl csak a Vector3-ket használunk.
        // Ugyanúgy mûködik, Vector2-re is.

        // Nevezetes vektorok:					//	X		Y		Z
        Vector3 right = Vector3.right;          //	1		0		0
        Vector3 left = Vector3.left;            //	-1		0		0
        Vector3 up = Vector3.up;                //	0		1		0
        Vector3 down = Vector3.down;            //	0		-1		0
        Vector3 forward = Vector3.forward;      //	0 		0		1     (Csak Vector3)
        Vector3 back = Vector3.back;            //	0 		0		-1    (Csak Vector3)

        Vector3 one = Vector3.one;              //	1		1		1
        Vector3 zero = Vector3.zero;            // 	0		0		0

        // Egyszerû vektor mûveletek:			//	X		Y		Z
        Vector3 sum = v3D2 + v3D3;              //	2		4		3
        Vector3 diff = v3D2 - v3D3;             //	-2		-2		-3
        Vector3 mult = v3D3 * 3f;               //	3		6		9
        Vector3 div = v3D3 / 2f;                //	0.5		1		1.5
        Vector3 negated = -v3D3;                //	-1		-2		-3

        // Egyszerûsített leírások:
        sum += v3D3;                            // sum = sum + v3D3
        diff -= v3D3;                           // diff = diff - v3D3
        mult *= 3f;                             // mult = mult * 3f
        div /= 3f;                              // div = div / 3f

        // Vektor hossza:
        float length = v3D3.magnitude;          // Vektor hossza
        float sqrLength = v3D3.sqrMagnitude;    // Vektor hosszának négyzete (jóval gyorsabb)

        // Vektor normalizálása:								// Irány megtart, hossza 1
        Vector3 normalized = v3D3.normalized;   // Vektor normalizáltjának lekérése
        v3D3.Normalize();                       // Vektor normalizálása



        // Lineáris interpoláció:
        Vector3 lerped = Vector3.Lerp(v3D1, v3D2, 0.5f);    // Lineáris interpoláció
        Vector3 slerped = Vector3.Slerp(v3D1, v3D2, 0.5f);  // Gömb interpoláció (Euler koord.) 

        // Egyéb
        float dist = Vector3.Distance(v3D1, v3D2);          // Helyvektorok távolsága
        float dot = Vector3.Dot(v3D1, v3D2);                // Skaláris szorzat
        Vector3 cross = Vector3.Cross(v3D1, v3D2);          // Vektori szorzat
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
