using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public float elapsedTime = 0;
    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    rb.useGravity = false;
    //}
    private void Update()
    {
        if(tag == "Ball Into Hole")
        {
            return;
        }    
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 10f && this.tag == "Ball Miss")
        {
            elapsedTime = 0;
            Destroy(gameObject);
        }    
    }
}
