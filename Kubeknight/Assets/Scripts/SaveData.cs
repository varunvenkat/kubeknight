using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SaveData : MonoBehaviour
{
    public float health;
    public float currentHealth;
    public float[] position;

    public SaveData(PlayerData player)
    {
        health = player.playerHealth;
        currentHealth = player.currentHealth;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
