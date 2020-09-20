using System;
using UnityEngine;
using System.Collections;


public class Move : MonoBehaviour
{
    public float force;
    public float downForce = 5f;
    private Rigidbody2D _rb;
    private bool _isGrounded;
    RaycastHit hit;
    private float lastHeight;
    private float currentHeight;
    private float height;
    private bool isScoreGrounded = false;
    
    

    private void Start()
    {
        
        lastHeight = transform.position.y;
        
        _rb = GetComponent<Rigidbody2D>();
        Debug.Log("Oyun Başladı!");

        isScoreGrounded = false;

    }


    void Update()
    {
        Controller();
        
        WriteLog();
        
        
    }

   

    private void OnCollisionStay2D(Collision2D other)
    {
        _isGrounded = true;
        isScoreGrounded = true;

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        _isGrounded = false;
    }    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ScoreTrigger") && isScoreGrounded)
        {
            ScoreText.score += 1;
            ScoreText.score = ScoreText.score * ComboText.comboScore;
            isScoreGrounded = false;
            
        }
        
    }


    public void Controller()
    {
        
        /* if (Physics.Raycast(transform.position, Vector3.down, out hit, 10f))
        {
            Debug.DrawRay(transform.position, Vector3.down);
        }
        transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal); */

        
        
        
        if (Input.GetMouseButton(0) && _isGrounded == false)
        {
            _rb.AddForce(Vector2.down * downForce ,ForceMode2D.Impulse);
        }

        if (Input.GetMouseButton(0) && _isGrounded == true)
        {
            
            _rb.AddForce(Vector2.right*force);
            
        }

        
    }

    void WriteLog()
    {
         
        if (transform.position.y > lastHeight && _isGrounded == false)
        { 
            Debug.Log("Yükseliyor!");
            lastHeight = transform.position.y;
        } 
        if(transform.position.y < lastHeight && _isGrounded == false) 
        { 
            Debug.Log("Düşüyor!");
            lastHeight = transform.position.y;
        }
        

    }
}