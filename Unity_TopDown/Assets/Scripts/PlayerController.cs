using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 playerDirection;
    private Rigidbody2D playerRigidbody2D;
    public float playerSpeed;


    //todo ao juntar com o mapa do marco, mudar a grabidade do niko para 0
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void FixedUpdate()
    {
        playerRigidbody2D.MovePosition(
            playerRigidbody2D.position + playerDirection * playerSpeed * Time.fixedDeltaTime
        );
    }
}
