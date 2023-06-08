using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseSaver : MonoBehaviour
{
    private void OnDestroy()
    {
        float x = transform.position.x;
        float z = transform.position.z;
        // Mentés
        PlayerPrefs.SetFloat("position x", x);
        PlayerPrefs.SetFloat("position z", z);
    }
    // Start is called before the first frame update
    void Start()
    {
        // Visszatöltés
        if (PlayerPrefs.HasKey("position x"))
        {
            float x = PlayerPrefs.GetFloat("position x");
            float z = PlayerPrefs.GetFloat("position z");
            transform.position = new Vector3(x, 0, z);
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DeleteSaveData()
    {
        PlayerPrefs.DeleteKey("position x");
        PlayerPrefs.DeleteKey("position z");
    }
}
