using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public int layerBallOfBot;
    public int layerBallOfPlayer;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball Miss")
        {
            
            if(other.gameObject.layer == layerBallOfPlayer)
            {
                Debug.Log("Var");
                PointManager.Instance.PlayerGetPoint();
                TurnManager.Instance.ChangeTurnToBot();
                other.GetComponent<PlayerController>().enabled = false;
            }    
            if(other.gameObject.layer == layerBallOfBot)
            {
                PointManager.Instance.BotGetPoint();
                TurnManager.Instance.ChangeTurnToPlayer();
                other.GetComponent<BotController>().enabled = false;
            }
            other.tag = "Ball Into Hole";
        }    
        
    }
}
