using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    [SerializeField] SpriteRenderer voidColorBlock;

    Rigidbody2D myRigidBody;
    BoxCollider2D myBodyCollider2D;
    private Vector2 moveDirection;


    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myBodyCollider2D = GetComponent<BoxCollider2D>();

        Time.timeScale = 1;
    }

    void Update()
    {
        ProcessInputs();
        Jump();
    }

    private void FixedUpdate()
    {
        playerMovement();
    }

    private void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        moveDirection = new Vector2(moveX, myRigidBody.velocity.y);
    }

    private void playerMovement()
    {
        GameSession gameSession = FindObjectOfType<GameSession>();
        
        if (!gameSession.levelComplete)
        {
            myRigidBody.velocity = new Vector2(moveDirection.x * moveSpeed, myRigidBody.velocity.y);
        }
    }

    private void Jump()
    {
        if (!myRigidBody.IsTouchingLayers(LayerMask.GetMask("Blocks")))
        {
            return;
        }

        if (Input.GetButtonDown("Jump"))
        {
            Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
            myRigidBody.velocity += jumpVelocityToAdd;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpriteRenderer>().color != voidColorBlock.color)
        {
            var hitColor = collision.gameObject.GetComponent<SpriteRenderer>().color;
            GetComponent<SpriteRenderer>().color = hitColor;
        }
    }


}
