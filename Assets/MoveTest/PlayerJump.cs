using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // 점프 힘 (조절 가능)
    private Rigidbody2D rb;
    private bool isGrounded; // 바닥에 닿아있는지 확인

    void Start()
    {
        // 오브젝트의 Rigidbody2D 컴포넌트를 가져옵니다.
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스바를 누르고, 바닥에 있는 상태일 때 점프
        if (Input.GetKeyDown(KeyCode.X) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    // 바닥과 충돌하고 있는지 체크 (간단한 방식)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
