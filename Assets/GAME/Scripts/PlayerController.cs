using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 mousePressDownPos;
    public Vector3 mouseReleasePos;
    //private bool isSliding = false;

    private Rigidbody rb;
    public bool isShoot = false;
    public bool isMoving = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
    private void Update()
    {
        if (TurnManager.Instance.currentGameState == GameState.Play)
        {
            if (!isShoot && Input.GetMouseButtonDown(0) && TurnManager.Instance.currentTurn == Turn.Player)
            {
                mousePressDownPos = Input.mousePosition;
                //isSliding = true;
            }
            if (!isShoot && Input.GetMouseButtonUp(0) && TurnManager.Instance.currentTurn == Turn.Player)
            {
                mouseReleasePos = Input.mousePosition;
                //isSliding = false;
                rb.useGravity = true;
                Shoot((mouseReleasePos - mousePressDownPos) / 2);
            }
            //if (Input.touchCount > 0)
            //{
            //    Debug.Log("Đang chạm");
            //    isSliding = true;
            //}
            //else if (Input.touchCount == 0 && isSliding == true)
            //{
            //    Debug.Log("Đang thả");
            //    isSliding = false;
            //}
            //if (isShoot && rb.velocity.magnitude < 0.01f)
            //{
            //    isMoving = false;
            //}
        }
           
    }  
    void Shoot(Vector3 force)
    {
        AudioManager.Instance.Play("Throw");
        if (isShoot)
            return;
        this.tag = "Ball Miss";
        rb.AddForce(new Vector3(force.x, force.y, force.y));
        GetComponent<Ball>().elapsedTime = 0;
        isShoot = true;
    }
}
