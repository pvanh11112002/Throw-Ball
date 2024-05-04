using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float elapsedTime = 0;
    public int layerBallOfBot;
    public int layerBallOfPlayer;
    public bool canDie = false;
    public bool startCount = false;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball Mis" || collision.gameObject.tag == "Ball Into Hole" )
        {
            AudioManager.Instance.Play("Cock");
        }
        else
        {
            AudioManager.Instance.Play("Collision Obj");
        }           
    }
    private void Update()
    {
        if (tag == "Ball Into Hole")
        {
            return;
        }
        if (canDie && this.tag == "Ball Miss")
        {
            if (gameObject.layer == layerBallOfPlayer)
            {
                TurnManager.Instance.ChangeTurnToBot();
            }
            else if (gameObject.layer == layerBallOfBot)
            {
                TurnManager.Instance.ChangeTurnToPlayer();
            }
            this.enabled = false;
        }
        if (rb.velocity != Vector3.zero)
        {
            startCount = true;
        }    
        if(startCount == true && rb.velocity.magnitude < 0.5f)
        {
            canDie = true;
        }    
    }
}
