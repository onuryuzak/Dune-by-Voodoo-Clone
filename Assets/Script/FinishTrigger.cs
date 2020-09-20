using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("Player").SendMessage("LevelFinish");
        SceneManager.LoadScene("RestartEndScene");
        ComboText.comboScore = 1;
        ScoreText.score = 0;
    }
}
