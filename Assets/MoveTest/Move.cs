#region 기본적인 움직이는 코드
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveX;
    private float moveY;

    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 좌우(A, D / 좌, 우 화살표) 입력
        moveX = Input.GetAxisRaw("Horizontal");
        // 상하(W, S / 상, 하 화살표) 입력
        moveY = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // X축과 Y축 모두 입력된 값에 속도를 곱해 이동합니다.
        rb.velocity = new Vector2(moveX * speed, moveY * speed);
    }
}
*/

#endregion

/*
    생성일자 : 2026.01.10
    파일이름 : Move.cs
    생성자:
    내용: 좌우 움직임 구현, 캐릭터의 방향에 따른 오브젝트 좌우 반전 구현 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   public GameManager1 gameManager;
    private Rigidbody2D rb;
    private float moveInput;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        Reversal(moveInput);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * gameManager.PlayerMoveSpeed, rb.velocity.y);
    }

    private void Reversal(float number)
    {

         if(number > 0 )
        {
            gameManager.Player.transform.localScale = new Vector2(-5.0f, gameManager.Player.transform.localScale.y);
        }
        else if(number < 0)
        {
            gameManager.Player.transform.localScale = new Vector2(5.0f, gameManager.Player.transform.localScale.y);
        }
        
    }
}
