using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InvinsibleWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball Miss")
        {
            other.gameObject.GetComponent<Rigidbody>().drag = 3;
        }
    }
}
