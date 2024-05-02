using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointAtCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointOfPlayer;
    [SerializeField] TextMeshProUGUI pointOfBot;

    private void Update()
    {
        pointOfPlayer.text = PointManager.Instance.pointOfPlayer.ToString();
        pointOfBot.text = PointManager.Instance.pointOfBot.ToString();
    }
}
