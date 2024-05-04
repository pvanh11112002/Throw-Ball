using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyControl : MonoBehaviour
{
    [SerializeField] Transform hole;
    void Awake()
    {
        transform.LookAt(hole);
        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }


    
}
