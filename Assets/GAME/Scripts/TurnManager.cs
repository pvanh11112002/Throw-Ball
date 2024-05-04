using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Mark here
public enum Turn
{
    Player,
    Bot
}
public enum GameState
{
    Play, Pause
}
public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance { get; private set; }
    [Header("Game Designer can change this due to each level")]

    [Tooltip("Prefab of the ball of Player")]
    public GameObject ballPrefabs;

    [Tooltip("Prefab of the ball of Bot")]
    public GameObject ballOfBotPrefabs;
    

    public GameObject ballHolder;

    [Tooltip("The point where player throw the ball")]
    public Transform throwPointOfPlayer;

    [Tooltip("Where bot throw the ball")]
    public Transform throwPointOfBot;

    [Tooltip("Maximum turn of this level")]
    public int howManyTurn = 0;

    [Tooltip("How many turn you want the bot to throw exactly to the hole")]
    public int numberOfTurnNotMiss = 0;

    [Header("Don't change this")]
    public Turn currentTurn;    
    public List<int> turnNotMiss = new List<int>();
    public int currentNumberTurnOfPlayer = 0;
    public int currentNumberTurnOfBot = 0;
    public GameState currentGameState;


    void Awake()
    {
        Instance = this;
        PlayerSpawnBall();
        currentGameState = GameState.Play;
        // Chọn ra những turn nào bot ném trúng
        for (int i = 0; i < numberOfTurnNotMiss; i++)
        {
            int temp = Random.Range(0, howManyTurn);
            while(turnNotMiss.Contains(temp))
            {
                temp = Random.Range(0, howManyTurn);
            }    
            turnNotMiss.Add(temp);
        }
        turnNotMiss.Sort();
        Debug.Log("Kết quả rand");
        foreach(int i in turnNotMiss)
        {
            Debug.Log(i);
        }


    }
    private void Update()
    {
        //if (howManyTurn > 1)
        //{
        //    if(Input.GetKeyDown(KeyCode.LeftArrow))
        //    {
        //        ChangeTurnToPlayer();
        //        //howManyTurn--;
        //    }
        //    if (Input.GetKeyDown(KeyCode.RightArrow))
        //    {
        //        ChangeTurnToBot();
        //        //howManyTurn--;
        //    }
        //    //if (Input.GetKeyDown(KeyCode.UpArrow))
        //    //{
        //    //    Debug.Log(currentTurn);
        //    //}

        //}
        //else
        //{
        //    Debug.LogWarning("Hết lượt ném");
        //}
        if (currentNumberTurnOfPlayer >= howManyTurn && currentNumberTurnOfBot >= howManyTurn)
        {
            currentGameState = GameState.Pause;
            GameManager.Instance.JudgeTheResult();
        }
    }
    public void ChangeTurnToBot()
    {
        if(currentTurn == Turn.Bot)
        {
            Debug.Log("Currently is bot turn, let him cook");
            return;
        } 
        else
        {
            Debug.Log("ChangeTurn");
            currentTurn = Turn.Bot;
            currentNumberTurnOfPlayer++;
            BotSpawnBall();
        }      
    }
    public void ChangeTurnToPlayer()
    {       
        if (currentTurn == Turn.Player)
        {
            Debug.Log("Currently is player turn, let him cook");
            return;
        }
        else
        {
            currentTurn = Turn.Player;
            currentNumberTurnOfBot++;
            PlayerSpawnBall();
        }
    }
    public void PlayerSpawnBall()
    {
        Instantiate(ballPrefabs, throwPointOfPlayer.position, Quaternion.identity, ballHolder.transform);
    }
    public void BotSpawnBall()
    {
        Instantiate(ballOfBotPrefabs, throwPointOfBot.position, Quaternion.identity, ballHolder.transform);
    }
    
}
