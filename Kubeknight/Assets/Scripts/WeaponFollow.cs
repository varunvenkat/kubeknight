using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFollow : MonoBehaviour
{
    Transform tr;
    Transform WeTr;
    public Player player;
    public float zOffset = 95;
    public float weaponRotationX = 90;
    Vector3 position;
    Vector3 positionA;
    public float rotation = 100;


    // Start is called before the first frame update
    void Start()
    {
        WeTr = GameObject.Find("WeaponHolder").transform;
        tr = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        position.Set(weaponRotationX, GameObject.Find("Player").transform.localEulerAngles.y, GameObject.Find("Player").transform.localEulerAngles.z - zOffset);
        positionA.Set(rotation, GameObject.Find("Player").transform.localEulerAngles.y, GameObject.Find("Player").transform.localEulerAngles.z - zOffset);
        if (!this.GetComponent<Attack>().isAttacking && !this.GetComponent<Attack>().isAttackingInProgress)
        {
            tr.localEulerAngles = position;
        }
        else if(!this.GetComponent<Attack>().isAttacking && !this.GetComponent<Attack>().isAttackingInProgress)
        {
            tr.localEulerAngles = positionA;
        }

        tr.position = WeTr.position;
    }

}
