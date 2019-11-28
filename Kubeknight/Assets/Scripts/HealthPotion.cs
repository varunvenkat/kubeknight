using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public float addedHealth = 20;
    public float health;
    public float Maxhealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = GameObject.Find("Player").GetComponent<PlayerData>().currentHealth;
        Maxhealth = GameObject.Find("Player").GetComponent<PlayerData>().playerHealth;
    }
    private void OnCollisionEnter(Collider other)
    {
        print("yeeeet");
        if (other.tag == "Player")
        {
            health = health + addedHealth;
        }
        if (health > Maxhealth)
        {
            health = Maxhealth;
        }
    }
}
