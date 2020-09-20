using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ComboSystem : MonoBehaviour
{
    private Rigidbody2D rb;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (rb.velocity.magnitude < 10)
        {
            ComboText.comboScore = 1;
        }

        Debug.Log("Your combo score is: " +ComboText.comboScore);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Combo"))
        {
            if (rb.velocity.magnitude >35)
            {
                ComboText.comboScore += 1;
                Debug.Log("Score = " +ComboText.comboScore);
            }

            
            
        }
    }

    
}
