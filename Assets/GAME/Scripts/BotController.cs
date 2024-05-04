using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    public static BotController Instance { get; private set; }
    [SerializeField] Transform hole;
    private Rigidbody rb;
    [SerializeField] float throwForce = 1;
    private bool canThrow = true;
    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody>();
        hole = GameObject.FindGameObjectWithTag("Hole").GetComponent<Transform>();
    }
    private void Update()
    {
        if (TurnManager.Instance.turnNotMiss.Contains(TurnManager.Instance.currentNumberTurnOfBot) && canThrow)
        {
            Bot_ThrowBall();
        }
        else if (!TurnManager.Instance.turnNotMiss.Contains(TurnManager.Instance.currentNumberTurnOfBot) && canThrow)
        {
            Bot_ThrowMiss();
        }
    }
    public void Bot_ThrowBall()
    {
        Vector3 direction = (hole.position - transform.position).normalized;
        direction = new Vector3(direction.x, direction.y, direction.y);
        rb.AddForce(direction * throwForce, ForceMode.Impulse);
        AudioManager.Instance.Play("Throw");
        this.tag = "Ball Miss";  
        canThrow = false;
    }    
    public void Bot_ThrowMiss()
    {
        
        int chooseSide = Random.Range(0, 2);
        Vector3 aimTarget = Vector3.zero;
        if (chooseSide == 0)
        {
            float rand = Random.Range(-1, 0);
            aimTarget = hole.position + new Vector3(rand, 0, 0);

        }
        else if (chooseSide == 1)
        {
            float rand = Random.Range(1, 2);
            aimTarget = hole.position + new Vector3(rand, 0, 0);
        }
        Vector3 direction = (aimTarget - transform.position).normalized;
        direction = new Vector3(direction.x, direction.y, direction.y);
        rb.AddForce(direction * throwForce, ForceMode.Impulse);
        AudioManager.Instance.Play("Throw");
        this.tag = "Ball Miss";
        canThrow = false;
    }    
}
