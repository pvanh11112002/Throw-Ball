using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointAtCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointOfPlayer;
    [SerializeField] TextMeshProUGUI pointOfBot;
    [SerializeField] TextMeshProUGUI turnOf;
    [SerializeField] TextMeshProUGUI reamainingTurnOfPlayer;
    [SerializeField] TextMeshProUGUI reamainingTurnOfBot;

    private void Update()
    {
        pointOfPlayer.text = PointManager.Instance.pointOfPlayer.ToString();
        pointOfBot.text = PointManager.Instance.pointOfBot.ToString();
        turnOf.text = TurnManager.Instance.currentTurn.ToString();
        reamainingTurnOfPlayer.text = "Remaining Turn Of Player: " + (TurnManager.Instance.howManyTurn - TurnManager.Instance.currentNumberTurnOfPlayer).ToString();
        reamainingTurnOfBot.text = "Remaining Turn Of Bot: " + (TurnManager.Instance.howManyTurn - TurnManager.Instance.currentNumberTurnOfBot).ToString();
    }
}
