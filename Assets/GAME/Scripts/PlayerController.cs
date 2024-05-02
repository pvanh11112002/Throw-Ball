using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 mousePressDownPos;
    public Vector3 mouseReleasePos;


    private Rigidbody rb;
    public bool isShoot = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    private void Update()
    {
        if(!isShoot && Input.GetMouseButtonDown(0) && TurnManager.Instance.currentTurn == Turn.Player)
        {
            mousePressDownPos = Input.mousePosition;
        } 
        if(!isShoot && Input.GetMouseButtonUp(0) && TurnManager.Instance.currentTurn == Turn.Player)
        {
            mouseReleasePos = Input.mousePosition;
            rb.useGravity = true;
            Shoot((mouseReleasePos - mousePressDownPos)/2);
            TurnManager.Instance.ChangeTurnToBot();
            
        }
        
    }  
    void Shoot(Vector3 force)
    {
        if (isShoot)
            return;
        this.tag = "Ball Miss";
        rb.AddForce(new Vector3(force.x, force.y, force.y));
        isShoot = true;
    }
}
