using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum GameCycle
{
    Start, End
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameCycle currentGameStatus;
    [SerializeField] GameObject winUI;
    [SerializeField] GameObject loseUI;
    private void Awake()
    {
        Instance = this;
        currentGameStatus = GameCycle.Start;
        winUI.SetActive(false);
        loseUI.SetActive(false);

        TurnManager.Instance.currentGameState = GameState.Pause;
    }
    public void JudgeTheResult()
    {
        if (PointManager.Instance.pointOfPlayer >= PointManager.Instance.pointOfBot)
        {
            winUI.SetActive(true);
            //AudioManager.Instance.TurnOfAllSounds();
            
        }
        else
        {
            loseUI.SetActive(true);
            
        }    
    }    
}
