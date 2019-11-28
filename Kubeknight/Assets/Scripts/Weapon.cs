using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage;
    public bool coolDownDone = true;
    public float coolDown = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator CoolDown ()
    {
        coolDownDone = false;
        yield return new WaitForSeconds(coolDown);
        coolDownDone = true;
        this.GetComponent<Attack>().attackingDone = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (this.GetComponent<Attack>().attackingDone) 
        {
            StartCoroutine(CoolDown());
        }
    }
}
