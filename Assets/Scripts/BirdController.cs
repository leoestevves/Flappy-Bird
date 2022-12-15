using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D birdRigidbody;

    [SerializeField] //Substituindo public por SerializeField
    private int jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        birdRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) //Jump definido no project settings;
        {
            Jump();
        }
        
    }
        
    void Jump()
    {
        birdRigidbody.velocity = Vector2.up * jumpForce; 
    }
}
