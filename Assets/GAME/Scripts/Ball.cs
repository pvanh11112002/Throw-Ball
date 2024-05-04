using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Mark deadTime
    public float elapsedTime = 0;
    public int layerBallOfBot;
    public int layerBallOfPlayer;
    [SerializeField] int deadTime;
    private void Update()
    {
        if(tag == "Ball Into Hole")
        {
            return;
        }    
        elapsedTime += Time.deltaTime;
        if (elapsedTime > deadTime && this.tag == "Ball Miss")
        {
            elapsedTime = 0;
            
            if (gameObject.layer == layerBallOfPlayer)
            {
                TurnManager.Instance.ChangeTurnToBot();
            }
            else if (gameObject.layer == layerBallOfBot)
            {
                TurnManager.Instance.ChangeTurnToPlayer();
            }
            Destroy(gameObject);
        }    
    }
}
