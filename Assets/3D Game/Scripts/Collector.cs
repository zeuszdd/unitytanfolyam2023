using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text collectedText;
    int collectedValue = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Collectable collectable))
        {
            collectedValue += collectable.Value;
            collectable.Jump();
            UpdateUI();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateUI()
    {
        collectedText.text = collectedValue.ToString();
    }
}
