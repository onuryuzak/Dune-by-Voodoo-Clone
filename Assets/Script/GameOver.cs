using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        

        if (other.gameObject.CompareTag("GameOver") && other.relativeVelocity.magnitude > 50)
        {
            SceneManager.LoadScene("GameOverandScene");
            GameObject.Find("Player").SendMessage("GameFinish");
            ComboText.comboScore = 1;
            ScoreText.score = 0;
        }
    }
}
