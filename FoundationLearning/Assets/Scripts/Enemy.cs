using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    int hitDamage;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    
        
    
}
