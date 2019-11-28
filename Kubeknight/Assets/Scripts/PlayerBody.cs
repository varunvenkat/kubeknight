using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {

        if (other.collider.tag == "Enemy")
        {
            
            string enemyID = other.collider.name;
            float damage = GameObject.Find(enemyID).GetComponent<EntityData>().enemyDamage;
            player.GetComponent<PlayerData>().currentHealth = player.GetComponent<PlayerData>().currentHealth - 20;
        }

    }
}
