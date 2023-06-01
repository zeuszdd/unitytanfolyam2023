using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] int value = 1;
    [SerializeField] Bounds teleportArea;
    public int Value => value;
    
    public void Jump()
    {
        float x = Random.Range(teleportArea.min.x, teleportArea.max.x);
        float y = Random.Range(teleportArea.min.y, teleportArea.max.y);
        float z = Random.Range(teleportArea.min.z, teleportArea.max.z);
        transform.position= new Vector3(x, y, z);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(teleportArea.center, teleportArea.size);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
