using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
  public GameManager1 gameManager;
    private Rigidbody2D rb;
    private bool isGrounded; // 바닥 체크

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        // Z키 점프
        if (Input.GetKeyDown(KeyCode.Z) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, gameManager.PlayerJumpForce);
        }

        //점프 상태 확인
        if (isGrounded)
        {
            gameManager.JumpConfirmation = false;
        }
        else
        {
            gameManager.JumpConfirmation = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
