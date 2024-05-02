using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager Instance { get; private set; }
    public int pointOfPlayer = 0;
    public int pointOfBot = 0;

    private void Awake()
    {
        Instance = this;
    }
    public void PlayerGetPoint()
    {
        Debug.Log("Call into player getpoint");
        pointOfPlayer++;
    }
    public void BotGetPoint()
    {
        pointOfBot++;
    }

}
