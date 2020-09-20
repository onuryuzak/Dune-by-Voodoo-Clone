using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboText : MonoBehaviour
{
    public static int comboScore = 1;
    

    private Text comboScoreText;

    
    // Start is called before the first frame update
    void Start()
    {
        comboScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        comboScoreText.text = "Combo Score: " + comboScore;
        
    }
}
