using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Damageable : MonoBehaviour
{
    [SerializeField, Min(1)] int maxHP = 100;
    [SerializeField] TMP_Text healthText;

    //[SerializeField, FormerlySerializedAs("minHP")] Color minHP = Color.red;
    //[SerializeField] Color maxHP = Color.green;
    [SerializeField] Gradient healthColor;
    [SerializeField] GameObject isDeadObject;

    int health;

    public int HealthLost
    { 
        get 
        { 
            return health; 
        }
        set 
        {
            health = maxHP - value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        health = maxHP;
        UpdateUI();

        int lost = HealthLost;
        HealthLost = 12;

        Vector3 pos =transform.position;
    }

    public int GetHealth()
    { 
        return health; 
    }
    
    public bool IsAlive()
    {
        return health > 0;
    }
   
    public void Damage(int n)
    {
        health -= n;
        health = Mathf.Max(health, 0);

        UpdateUI();
        //Debug.Log("AAAUUUUUU!" + health);
    }

    void UpdateUI()
    {
        float t = (float)health / maxHP;
        //Color c = Color.Lerp(minHPColor, maxHPColor, t);
        Color c = healthColor.Evaluate(t);

        healthText.color = c;
        healthText.text = "HP: " + health;

        isDeadObject.SetActive(!IsAlive());
    }
}
