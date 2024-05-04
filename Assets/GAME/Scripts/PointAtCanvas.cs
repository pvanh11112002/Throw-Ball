using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointAtCanvas : MonoBehaviour
{
    // Mark here turnOf.text = TurnManager.Instance.currentTurn.ToString();
    [SerializeField] TextMeshProUGUI pointOfPlayer;
    [SerializeField] TextMeshProUGUI pointOfBot;
    [SerializeField] TextMeshProUGUI turnOf;
    [SerializeField] TextMeshProUGUI reamainingTurnOfPlayer;
    [SerializeField] TextMeshProUGUI reamainingTurnOfBot;

    private void Update()
    {
        if (TurnManager.Instance.currentGameState == GameState.Play) 
        {
            pointOfPlayer.text = PointManager.Instance.pointOfPlayer.ToString();
            pointOfBot.text = PointManager.Instance.pointOfBot.ToString();
            turnOf.text = TurnManager.Instance.currentTurn.ToString();
            reamainingTurnOfPlayer.text = "Remaining Turn Of Player: " + (TurnManager.Instance.howManyTurn - TurnManager.Instance.currentNumberTurnOfPlayer).ToString();
            reamainingTurnOfBot.text = "Remaining Turn Of Bot: " + (TurnManager.Instance.howManyTurn - TurnManager.Instance.currentNumberTurnOfBot).ToString();
        }      
    }
}
