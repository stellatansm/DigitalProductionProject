using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRigidBody;

    public Sprite idle;
    public Sprite walking;
    public Sprite closedEyes;
    public Sprite breath;

    
    public float speed = 8f;
    public float dirX;
    public float input;
    
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody= GetComponent<Rigidbody2D>();
        spriteRenderer= GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = idle;
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.V))
        {
            speed = 4f;
            spriteRenderer.sprite = breath;
        }
        else
        {
            speed = 9f;
            spriteRenderer.sprite = idle;
        }


        if (input < 0)
        {
            spriteRenderer.flipX = true; 
        }
        else if (input > 0)
        {
            spriteRenderer.flipX = false;
        }

    }
    void FixedUpdate() //set to run 50 frames per second
    {
        playerRigidBody.velocity = new Vector2(input * speed, playerRigidBody.velocity.y);
        
    }
}
