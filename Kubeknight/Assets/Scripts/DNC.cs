using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNC : MonoBehaviour
{
    public float time = 0.25f;
    public bool isTiming = false;
    public Transform tr;
    public float rotater = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator dayNightCycle()
    {
        yield return new WaitForSeconds(time);
        tr.Rotate(rotater,0,0);
        isTiming = false;
    }

    // Update is called once per frame
    void Update()
    {      
        if (!isTiming) {
            StartCoroutine(dayNightCycle());
            isTiming = true;
        }
    }
}
