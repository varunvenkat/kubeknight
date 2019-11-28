using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PlayerData : MonoBehaviour
{
    public GameObject player;
    public float playerHealth = 500f;
    public float currentHealth = 500f;
    public float HBar;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        float enemyDamage = enemy.GetComponent<EntityData>().enemyDamage;
    }

    

    // Update is called once per frame
    void Update()
    {
        HBar = currentHealth / playerHealth;

        if (transform.position.y < -50)
        {
            currentHealth = 0;
        }
       if (currentHealth <= 0)
        {
            GetComponent<ChangeScene>().changeTheScene(1);
        }
    }

    
}
