using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasWin : MonoBehaviour
{
    private void OnEnable()
    {
        AudioManager.Instance.Play("Win");
        AudioManager.Instance.TurnOfAllSounds();
    }
    public void Next()
    {
        Application.Quit();
    }    
}
