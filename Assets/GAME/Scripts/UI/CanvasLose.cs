using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLose : MonoBehaviour
{
    private void OnEnable()
    {
        AudioManager.Instance.Play("Lose");
        AudioManager.Instance.TurnOfAllSounds();
    }
    public void Next()
    {
        Application.Quit();
    }
}
