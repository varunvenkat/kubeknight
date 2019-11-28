using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public GameObject target;
    public Transform tr;

    private void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }
}