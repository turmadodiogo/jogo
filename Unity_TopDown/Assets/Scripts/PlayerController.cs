using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ReSharper disable All

public class PlayerController : MonoBehaviour
{
    private Vector2 playerDirection;
    private Rigidbody2D playerRigidbody2D;
    private Animator playerAnimator;
    public float playerSpeed;

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (playerDirection.sqrMagnitude > 0)
        {
            playerAnimator.SetInteger("Movimento", 1);
        }
        else
        {
            playerAnimator.SetInteger("Movimento", 0);
        }
        Flip();
    }

    void FixedUpdate()
    {
        playerRigidbody2D.MovePosition(
            playerRigidbody2D.position + playerDirection * playerSpeed * Time.fixedDeltaTime
        );
    }

    void Flip()
    {
        if (playerDirection.x > 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        else if(playerDirection.x < 0)
        {
            transform.eulerAngles = new Vector2(0f, 180);
        }
    }
}
