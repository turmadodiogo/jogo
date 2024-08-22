using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private float horinzontal;
    private Rigidbody2D rb;
    [SerializeField] private int velocidade = 5;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    /*void Start()
    {
    }*/
    // Update is called once per frame
    void Update()
    {
        horinzontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horinzontal * velocidade, rb.velocity.y);
    }
}
