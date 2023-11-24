using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    public float speedX;
    public int directionX;
    public int directionY;

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            directionX = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            directionX = -1;
        }
        else
        {
            directionX = 0;
        }

        if (Input.GetKey(KeyCode.W))
        {
            directionY = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            directionY = -1;
        }
        else
        {
            directionY= 0;
        }
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speedX * directionX, speedX * directionY);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HorizontalWall")
        {
            directionX = 0;
        }

        else if (collision.gameObject.tag == "VerticalWall")
        {
            directionY = 0;
        }
    }
}

