using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks.Dataflow;
using System;
using UnityEngine;
using System.Collections.Generic;


public class Homework : MonoBehaviour
{
    /*
    // Értékcsere
    int a=3; 
    int b=8;
    a+=b;
    b-=a;
    b=-b;
    a-=b;
    */
    // Lépkedés fix sebességgel
    class StepMover:MonoBehaviour
    {
        [SerializeField] float speed;
        Vector3 target;
        void Start()
        {
            target=transform.position;
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            target += Vector3.up;
            if (Input.GetKeyDown(KeyCode.DownArrow))
            target += Vector3.down;
            if (Input.GetKeyDown(KeyCode.RightArrow))
            target += Vector3.right;
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            target += Vector3.left;

            Vector3 selfPos = transform.position;
            transform.position = Vector3.MoveTowards(selfPos,target,speed * Time.deltaTime);
        }
    }

 

    /*
    int SzamjegyOsszeg(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            int szamjegy = n % 10;
            sum += szamjegy;
            n /= 10;
        }
        return sum;
    }

    int[] sorrend(int[] array)
    {
        if (array == null)
        {
            return null;
        }
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            int i2 = array.Length - 1 - i;
            newArray[i] = array[i2];
        }
        return newArray;
    }

    int[] Fibonacci(int length)
    {
        int[] result = new int[length];
        
        if (length > 0)
        {
            result[0] = 0;
        }
        if (length > 1)
        {
            result[1] = 1;
        }
        for (int i = 2; i < length; i++)
        {
            result[i] = result[i - 1] + result[i - 2];
        }
        return result;
    }

    int Betuszamlalo(string s)
    {
        List<char> characters = new List<char>();
        foreach (char c in s)
        {
            if (!characters.Contains(c))
            {
                characters.Add(c);
            }
        }
        return characters.Count;

    }
    /*
    class NormalizedDirectionVector : MonoBehaviour
    {
        [SerializeField] Vector2 a, b;

        [SerializeField] int stepCount;
        [SerializeField] Vector2 step;

        void OnValidate()
        {
            Vector2 dirVec = b - a;
            float tavolsag = dirVec.magnitude;
            stepCount = Mathf.CeilToInt(tavolsag);
            step = dirVec / stepCount;
        }
    }
    */
    

    /*
    // [SerializeField] int a;
    // [SerializeField] int b;
    // Start is called before the first frame update
    void Start()
    {
        // 1. feladat
        int a = 38;
        int b = 5;
        float c = (a / b);
        int dd = a % b;
        Debug.Log("{a}-ban a(z) {b} megvan {c} -szer, maradék: {d}.");

        // 2. feladat
        a = 2; b = 4; c = 5;
        string d = "D", e = "E", f = "F";

        int x1 = a + b + c;
        string x2 = a + b + e;
        string x3 = b + d + c;
        string x4 = f + a + b;

        float x5 = a + b * c;
        x5 /= 8;
        float x6 = x5 / b;
        x6++;
        float x7 = x6 / 2f;
        x7--;
        float x8 = -1 * x7;
        x8 *= x8;

        // 3. feladat
        int number;
        int summa;
        summa = 0;
        for (int i = 1; i <= number; i++)
        {
            summa += i;
        }
        Debug.Log("Az osszeg: {summa}.");

        // 4. feladat
        int number = 1;
        bool fizz = i % 3 == 0;
        bool fizz = i % 5 == 0;
        for (int i = 1; i <= number; i++)
        {
            if (fizz && buzz)
            {
                Debug.Log("FizzBuzz");
            }
            else if (fizz)
            {
                Debug.Log("fizz");
            }
            else if (buzz)
            {
                Debug.Log("buzz");
            }
            else
            {
                Debug.Log(i);
            }
        }


        // 5. feladat
        int baseNumber = 1;
        int exponent = 1;

        int result;

        result = Math.Pow(baseNumber, exponent);

        /*
        for (int i = 0; i < exponent; i++)
        {
            result*=baseNumber;
        }
        */
    /*
        Debug.Log($"Az eredmény: {result}");

        // 6. feladat
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Debug.Log($"{i}*{j}={i * j}");
            }
        


    // Update is called once per frame
    void Update()
    {

    }
*/

}

   /*
    Írj komponenst, ami egy 6 ágú keresztet rajzol a térben pont oda, ahol a komponenshez tartozó GameObject elhelyezkedik!

A keresztnek 3 egymással merőleges tengelye legyen!

A kereszt ágai arra mutassanak, amerre a GameObject lokális jobbra, balra, fel, le, előre és hátra iránya mutat.

A kereszt ágai meghatározott színűek legyenek:

- X tengely: 🔴 Piros
- Y tengely: 🟢 Zöld
- Z tengely: 🔵 Kék

Az ágak hossza megegyezik. A hossz egy `[SerializeField]` mezővel beállítható.

Bónusz: A pozitív irányokba (jobbra, fel, előre) mutató ágak végére rajzoljatok egy kis gömböt!
    */


public class Tester : MonoBehaviour
{
	[SerializeField] float length;  // Egy tengely hossza
    
    void OnDrawGizmos()
    { 
	    Vector3 p = transform.position;

        DrawAxis(p, Vector3.right, Color.red);
        DrawAxis(p, Vector3.up, Color.green);
        DrawAxis(p, Vector3.forward, Color.blue);
    }
    
    void DrawAxis(Vector3 center, Vector3 axis, Color color)
    {
		Vector3 direction = length * transform.TransformDirection(axis);
		Gizmos.color = color;
		Gizmos.DrawLine(center - direction, center + direction);
		Gizmos.DrawSphere(center + direction, 0.1f * length);
    }
}

/*
Írj követőrakéta komponenst! A komponens-nek van egy `[SerializeField] Transform target` beállítása. 
A követőrakéta mindig ezt a célpontot próbálja elérni a 3D térben.

A rakéta mindig csak…

- előrefelé haladhat egy beállítható fix sebességgel, és
- legfeljebb fix szögsebességgel fordulhat.
*/
public class Rocket : MonoBehaviour
{
	[SerializeField] Transform target;
	[SerializeField] float speed = 5;
	[SerializeField] float angularSpeed = 180;
	
	void Update()
	{
		Transform self = transform;
		
		Vector3 targetDirection = target.position - self.position;  // Ebben az irányban van a cél
		Quaternion targetRotation = Quaternion.LookRotation(targetDirection);   // Ahhoz ebbe az irányba akarunk fordulni
		
		// Fordulás:
		float maxAngle = angularSpeed * Time.deltaTime;  // Maximum ekkora szögben fordulhatunk most
		self.rotation = Quaternion.RotateTowards(self.rotation, targetRotation, maxAngle);  // Towards metódus
		
		// Haladás:
		float offset = speed * Time.deltaTime;   // Ennyit lépünk előre
		self.position += self.forward * offset;  // Előre irányba megyünk
	}
}