using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float playerSpeed = 12;
    private Vector2 playerDirection;
    private Rigidbody2D rb;

    public static bool startGame;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (startGame == false)
            return;

        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        if (startGame == false)
            return;

        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("player=" + collision.gameObject.name);
        if (collision.CompareTag("Obstacle"))
        {
            Player.startGame = false;
        }
    }

}

