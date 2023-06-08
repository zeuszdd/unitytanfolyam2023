using System.Security.Cryptography;
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

/*
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>netcoreapp1.0</TargetFramework>
    </PropertyGroup>
</Project>
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>netcoreapp1.0</TargetFramework>
    </PropertyGroup>
</Project>
elso
using UnityEngine;

public class ConnectingLine : MonoBehaviour
{
    [SerializeField] Transform other;
    [SerializeField] float maxLength = 10;

    void OnDrawGizmos()
    {
        if (other == null)
            return;

        Vector3 otherPos = other.position;
        Vector3 selfPos = transform.position;
        
        // Távolság kiszámítása
        float distance = Vector3.Distance(otherPos, selfPos);
        
        // Ha határértéken belül van a másik objektum
        if (distance <= maxLength)
        {
            if (distance > maxLength * 0.9f)   // Ha 90% felett
                Gizmos.color = Color.red;
            else
                Gizmos.color = Color.green;
            
            Gizmos.DrawLine(otherPos, selfPos);
        }
    }
}
masodik
public classChildRotator: MonoBehaviour
{
    [SerializeField] floatbaseAngularSpeed= 1f;

    void Update()
    {
        foreach (Transform child in GetComponentsInChildren<Transform>())
        {
            if (child.GetComponent<MeshRenderer>() != null)
            {
                float angularSpeed = baseAngularSpeed;
								
								//Bónusz feladat:
								angularSpeed /= Vector3.Distance(child.position, transform.position);

                child.Rotate(0, angularSpeed * Time.deltaTime, 0);
            }
        }
    }
}
harmadik
string[] Combine(string[] a1, string[] a2)
{
	string[] c = new string[a1.Length + a2.Length];
	
	for (int i = 0; i < a1.Length; i++)
		c[i] = a1[i];
	
	for (int i = 0; i < a2.Length; i++)
		c[a1.Length + i] = a2[i];
	
	return c;
}
bonusz
int BinaryToDecimal(int binaryNum)
{
    int decimalNum = 0;    // Kinullázom a végeredményt 
    int digitValue = 1;    // Ebben számolom, hogy az egyes helyiértéken mennyivel szorzunk

    while (binaryNum > 0)  // Egyenként végigmegyek a bináris szám minden számjegyén
    {
        int digit = binaryNum % 10;    // Levágjuk az utolsó számjegyet

        if (digit > 1)         // Ha bármelyik számjegy nem 0 vagy 1
        {
            decimalNum = 0;    // akkor az eredmény 0
            break;             // ás kilépünk a ciklusból
        }

        decimalNum += digit * digitValue;

        binaryNum = binaryNum / 10;   // Törlöm az utolsó számjegyet (Azt már kezeltem)
        digitValue *= 2;              // Következő helyiérték már dupla akkora szorzójú
    }

    return decimalNum;
}
/*
- **Lézer célzó**
    
    Írj komponenst, ami egy sugarat lő (Raycasting) saját pozíciójából lokális előre irányába!
    
    A komponensnek [SerializeField] beállításként megadható GameObject-ek egy tömbje.
    
    Ha a sugárvetés célt talált, akkor tömb elemeit felsorakoztatja a célzás és találat pontjai közé egyenlő távolságra. Ha a sugárvetés nem talált célt, a tömb elemeit inaktiválja!
    
    Lehessen a komponensnek beállítani maximális távolságot!

    using UnityEngine;

public class Pointer : MonoBehaviour
{ 
    [SerializeField] float rayLength = 100f;
    [SerializeField] GameObject[] objects;

    void Update()
    {
        Vector3 position = transform.position; // Pozíció
        Ray ray = new Ray(position, transform.forward); // Előre mutató sugár

        bool isHit = Physics.Raycast(ray, out RaycastHit hit, rayLength); // Sugárvetés = raycast

        foreach (GameObject o in objects)   // Végigmegyek az összes objektumon
            o.SetActive(isHit);             // Ki vgy be kapcsolom az objektumokat
                                            // függően attól, hogy történt e találat

        if (isHit) // Ha van találat
        {
            for (int index = 0; index < objects.Length; index++) // Az összese elemre:
            {
                float rate = index / (objects.Length - 1f); // 0-1 közötti érték
                Vector3 p = Vector3.Lerp(position, hit.point, rate); // Lineáris interpoláció
                objects[index].transform.position = p; // Pozíció beállítása
            }
        }
    }

    void OnDrawGizmos()
    {
        Vector3 position = transform.position;                                  // Pozíció
        Ray ray = new Ray(position, transform.forward );            // Előre mutató sugár 
        Gizmos.color = Color.red;                                               // Gizmos színe
        Gizmos.DrawLine(ray.origin, ray.origin + (ray.direction * rayLength));  // Sugár kirajzolása 
    }

    2.
    Írj bolygó (Planet) komponenst, aminek gravitációs hatása van minden többi bolygóra.

Minden bolygónak van egy beállítható tömege.

Minden test vonz egy másik testet a Newtoni tömegvonzás törvénye szerint.

A megoldáshoz ne használj RigidBody-t!
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField, Min(0)] float mass = 1;   // tömeg 
    
    Vector3 velocity;             // Sebességvektor

    // Kiszámolom a méretet a tömeg alapján (NEM VOLT FELADAT)
    void OnValidate()
    {
        float scale = Mathf.Pow(mass, 1/3f); // a tömeg köbgyöke
        transform.localScale = new Vector3(scale, scale, scale);
    }

    // A gyorsulást és lassulást érdemes a FixedUpdate-ben kezelni:
    void FixedUpdate()
    {
        float gravity = 5; // Newton féle gravitatációs állandó (saját értékkel)
        foreach (var otherPlanet in FindObjectsOfType<Planet>())  // Minden egyéb bolygó hat ránk
        {
            if(otherPlanet == this)    // Saját magára nem hat a bolygó
                continue; // Következő bolygóra lépünk
            
            Vector3 distanceVector = otherPlanet.transform.position - transform.position;
            if(distanceVector == Vector3.zero)
                continue; // Következő bolygóra lépünk
            
            float distance = distanceVector.magnitude;      // Távolság
            Vector3 direction = distanceVector.normalized;  // Irányvektor
            
            float acceleration = gravity * otherPlanet.mass / distance;
            // NEM A TÁVOLSÁG NÉGYZETÉVEL OSZTOK!!!
            // Mint az a valós fizika szerint történne!
            // Ennek oka, hogy túl nehéz vele stabil rendszert építeni, ami nem esik szét.
            
            velocity += direction * (acceleration * Time.fixedDeltaTime); // gravitációs gyorsulás
        }
    }
    
    // Az elmozdulást érdemes az Update-ben kezelni:
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    // Sebességvektor kirajzolása (NEM VOLT FELADAT)
    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1,1,1,0.25f); // Átlátszó fehér 
        Gizmos.DrawLine(transform.position, transform.position + (velocity * 0.5f)); // Sebességvektor
    }
}
3.
// Listával és triggerekkel

using System.Collections.Generic;
using UnityEngine;

class GravityModifier : MonoBehaviour
{
		//Kifejtett gyorsulás
    [SerializeField] Vector3 gravity = new(0, 10, 0); 

		// Itt tárolom az éppen triggeren belül lévőket
    List<Rigidbody> _rigidbodies = new();

		// Tárolom a belépőket
    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.attachedRigidbody;
        if (rb != null)            
            _rigidbodies.Add(rb);
    }
    
		// Törlöm a listából a távozókat
    void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.attachedRigidbody;
        if (rb != null)
            _rigidbodies.Remove(rb);
    }

    void FixedUpdate()
    { 
				// Hozzáadom a gyorsulást
        foreach (Rigidbody rb in _rigidbodies)
		        rb.AddForce(gravity, ForceMode.Acceleration);
    }
}
}
*/
/*
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{ 
    [SerializeField] float rayLength = 100f;           // Sugárvetés maximális hossza
    [SerializeField] float distance = 0.25f;           // Két célzópont távolsága
    [SerializeField] GameObject prototype;             // Ebből készítünk másolatokat

    List<GameObject> objects = new List<GameObject>(); // Ebbe a listába tesszük ez elemeket

    void Update()
    {
        Vector3 position = transform.position;            // Pozíció
        Vector3 forward = transform.forward;              // Előre irány
        Ray ray = new Ray(position, forward); // Előre mutató sugár

        bool isHit = Physics.Raycast(ray, out RaycastHit hit, rayLength); // Sugárvetés = raycast 
        
        int count = 0; // Hány elemet rejzoljuk ki
        
        if (isHit) // Ha van találat
        {
            // Hány elemet rejzoljuk ki:
            count = Mathf.CeilToInt(Vector3.Distance(position, hit.point) / distance);
            
            // Ha nincsenek létrehozva, példányosítom és eltárolom a célzópontokat
            while (count > objects.Count)
            {
                GameObject newInstance = Instantiate(prototype);
                objects.Add(newInstance);
            }
            
            for (int i = 0; i < count; i++)     // Az összese megjelenítendő objektumra:
            {
                objects[i].SetActive(true);                         // bekapcsolás
                Vector3 p = position + (i * distance * forward);    // pozíció kiszámítása
                objects[i].transform.position = p;                  // Pozíció beállítása
            }
        }

        // Az összese NEM megjelenítendő objektumra:
        for (int i = count; i < objects.Count; i++)
            objects[i].SetActive(false);  // kikapcsolás
    }

    void OnDrawGizmos()
    {
        Vector3 position = transform.position;                                  // Pozíció
        Ray ray = new Ray(position, transform.forward );            // Előre mutató sugár 
        Gizmos.color = Color.red;                                               // Gizmos színe
        Gizmos.DrawLine(ray.origin, ray.origin + (ray.direction * rayLength));  // Sugár kirajzolása 
    }
}
2. feladat
using UnityEngine;
 
public class Magnet : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float power;
    [SerializeField] bool isPositive;
 
    void FixedUpdate()
    {
        Magnet[] magnets = FindObjectsOfType<Magnet>();

//  	  for(int i = 0; i < magnets.Length; i++) // for ciklus is lehetne
//			{
//					Magnet other = magnets[i];

        foreach (Magnet other in magnets)       // for ciklus is lehetne
        {                                       // Látsd fentebb ↑

            if (other == this) continue;        // Saját magára nem hat
            
            Vector2 vector = other.transform.position - transform.position;
            float distance = vector.magnitude;  // Távolság
            Vector2 direction = vector;         // Irány
            
            if(isPositive != other.isPositive)  // Ha ellentétesek a pólusok
                direction *= -1;                // akkor vonzzák egymást
            
            //A kifejtett erő:

						// egyenesen arányos mindkét pólus erejével,
            float force = power * other.power;
						// és fordítottan a távolság négyzetével.
            force /= distance * distance;
            
						// Erőt fejtünk ki a másikra
            other.rigidbody.AddForce(direction * force);
        }
    }
}
3. feladat

Készíts bombát, ami egy idő letelte után ellöki a körülötte lévő RigidBody-kat és megsemmisíti önmagát.

A robbanásnak van egy beállítható ereje és hatótávolsága.

A hatótáv széléhez közeledve gyengül a lökés ereje.

- Illusztráció
    
    [2022-10-24_18-13-03-523 (2).mp4](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/62778800-125d-47b5-ad56-eb62f4e897fd/2022-10-24_18-13-03-523_(2).mp4)
    
- Megoldás
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] float delay = 5f;
    [SerializeField] float force = 25f;
    [SerializeField] float range = 5f;
    [SerializeField] float up = 0.5f;
    
    float _startTime;

    void Start()
    {
        _startTime = Time.time;
    }

    void Update()
    {
        if (Time.time - _startTime > delay)
        {
            Explode();
            Destroy(gameObject);
        }
    }

    void Explode()
    {
        Rigidbody[] rigidbodies = FindObjectsOfType<Rigidbody>();
        foreach (Rigidbody rb in rigidbodies)
						rb.AddExplosionForce(
								force,
								transform.position,
								range,
								up,
								ForceMode.Impulse); 
	  }
}
*/