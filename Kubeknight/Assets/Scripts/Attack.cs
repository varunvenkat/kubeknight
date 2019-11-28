using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Attack : MonoBehaviour
{
    public bool isAttacking = false;
    public float smooth = 20;
    public Transform tr;
    public bool isAttackingInProgress = false;
    public float WaitForSeconds = 0.1f;
    public bool attackingDone = false;

    // Start is called before the first frame update
    void Start()
    {
        //<timer> 

        //</timer>
    }
    IEnumerator onTimer()
    {
        print(transform.position);
        yield return new WaitForSeconds(WaitForSeconds);
        print(transform.position);
        tr.Rotate(0, -100, 0);
        isAttackingInProgress = false;
        attackingDone = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            isAttacking = true;
        }
        else
        {
            isAttacking = false;
        }
        if (isAttacking && !isAttackingInProgress && this.GetComponent<Weapon>().coolDownDone)
        {
            tr.Rotate(0,100,0);
            isAttackingInProgress = true;
            StartCoroutine(onTimer());
        } 
  
    }

}






