using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementForce;
    [SerializeField] private float jumpForce;

    [SerializeField] private Joystick joystick;

    private Rigidbody2D rigidbody2D;

    private float moveHorizontal;

    private bool isGrounded = true;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(moveHorizontal * movementForce * Time.deltaTime, rigidbody2D.velocity.y);
    }

    private void Update()
    {
        moveHorizontal = joystick.Horizontal;

        if (joystick.Vertical > 0.5f)
        {
            Jump();
        }
    }

    private void Jump() {
        if (isGrounded)
        {
            rigidbody2D.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ground>()) {
            isGrounded = true;
        }
    }
}
