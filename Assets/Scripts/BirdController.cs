using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D birdRigidbody;
    public  int         jumpForce;

    private LogicScript _LogicScript;
    private bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        birdRigidbody = GetComponent<Rigidbody2D>();
        _LogicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && birdIsAlive) //Jump definido no project settings;
        {
            Jump();
        }      
    }
        
    void Jump()
    {
        birdRigidbody.velocity = Vector2.up * jumpForce; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _LogicScript.gameOver();
        birdIsAlive = false;
    }
}
