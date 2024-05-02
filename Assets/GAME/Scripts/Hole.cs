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
            }    
            if(other.gameObject.layer == layerBallOfBot)
            {
                PointManager.Instance.BotGetPoint();
            }
            other.tag = "Ball Into Hole";
        }    
        
    }
}
