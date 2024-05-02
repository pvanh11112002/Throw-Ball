using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Turn
{
    Player,
    Bot
}
public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance { get; private set; }
    public GameObject ballPrefabs;
    public GameObject ballHolder;
    [SerializeField] int howManyTurn = 0; 
    public Turn currentTurn;
    
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        SpawnBall();
    }
    private void Update()
    {
        if (howManyTurn > 1)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                ChangeTurnToPlayer();
                howManyTurn--;
            }               
        }
        else
        {
            Debug.LogWarning("Hết lượt ném");
        }
    }
    // Update is called once per frame
    public void ChangeTurnToBot()
    {
        currentTurn = Turn.Bot;
    }
    public void ChangeTurnToPlayer()
    {
        currentTurn = Turn.Player;
        SpawnBall();
    }
    public void SpawnBall()
    {
        Instantiate(ballPrefabs, new Vector3(0, 1, 0), Quaternion.identity, ballHolder.transform);
    }   
    public void SpawnBallAfter(float time)
    {
        Invoke(nameof(SpawnBall), time);
    }    
       
}
