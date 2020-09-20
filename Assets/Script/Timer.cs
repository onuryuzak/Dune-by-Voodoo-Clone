using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float startTime;
    private bool finished = false;
    private string seconds;
    void Start()
    {
        startTime = Time.time;
    }

    
    void Update()
    {
        if (finished)
            return;
        
        float t = Time.time - startTime;
        seconds = (t % 60).ToString("F0");

        
    }

    public void LevelFinish()
    {
        finished = true;
        Debug.Log("Level has finished in " +seconds+  " seconds");
    }

    public void GameFinish()
    {
        finished = true;
        Debug.Log("Game has finished in " +seconds+ " seconds.");
    }
}
