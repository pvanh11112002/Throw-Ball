using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLevelSelector : MonoBehaviour
{
    public static CanvasLevelSelector Instance { get; private set; }
    public int maximumTurn;
    public int numberTurnNotMiss;
    public GameObject turnManager;
    private void Awake()
    {
        Instance = this;      
    }
    public void Level1()
    {
        maximumTurn = 3;
        numberTurnNotMiss = 1;
        turnOnTurnManager();
        AudioManager.Instance.Play("Button Click");
        
    }
    public void Level2()
    {
        maximumTurn = 5;
        numberTurnNotMiss = 2;
        turnOnTurnManager();
        AudioManager.Instance.Play("Button Click");
        
    }
    public void Level3()
    {
        maximumTurn = 7;
        numberTurnNotMiss = 3;
        turnOnTurnManager();
        AudioManager.Instance.Play("Button Click");
    }
    public void Level4()
    {
        maximumTurn = 8;
        numberTurnNotMiss = 4;
        turnOnTurnManager();
        AudioManager.Instance.Play("Button Click");
    }
    public void Level5()
    {
        maximumTurn = 9;
        numberTurnNotMiss = 5;
        turnOnTurnManager();
        AudioManager.Instance.Play("Button Click");
    }
    public void Level6()
    {
        maximumTurn = 10;
        numberTurnNotMiss = 5;
        turnOnTurnManager();
        AudioManager.Instance.Play("Button Click");
    }
    public void Level7()
    {
        maximumTurn = 11;
        numberTurnNotMiss = 6;
        turnOnTurnManager();
        AudioManager.Instance.Play("Button Click");
    }
    public void Level8()
    {
        maximumTurn = 12;
        numberTurnNotMiss = 7;
        turnOnTurnManager();
        AudioManager.Instance.Play("Button Click");
    }
    private void turnOnTurnManager()
    {
        turnManager.GetComponent<TurnManager>().enabled = true;
        this.gameObject.SetActive(false);
    }
}
