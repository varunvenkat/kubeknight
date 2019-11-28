using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityData : MonoBehaviour
{
    public float entityHealth = 5f;
    public Rigidbody rb;
    public float enemyDamage = 20;
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Weapons")
        {
            enemyDamage = GameObject.Find(collisionInfo.collider.name).GetComponent<Weapon>().damage;
            entityHealth = entityHealth - enemyDamage;
        }
        if (collisionInfo.collider.tag == "Player")
        {
            
        }
    }

    void Update()
    {
        if (entityHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
} 