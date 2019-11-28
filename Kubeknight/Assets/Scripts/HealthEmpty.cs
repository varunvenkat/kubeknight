using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEmpty : MonoBehaviour
{
    public RectTransform tr;
    private float health;
    

    private void Start()
    {
    }



    // Update is called once per frame
    void Update()
    {
        health = GameObject.Find("Player").GetComponent<PlayerData>().HBar;
        tr.localScale = new Vector3(health, 1, 1);       
    }
}
