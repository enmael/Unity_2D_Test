/*
    생성일자 : 2026.01.10
    파일이름 : DoubleJump.cs
    생성자:
    내용: 더블 점프 구현하기 구현중 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    //1.점프 상태인지를 확인한다.(o)
    //2.잠프 상태에서 x키를 눌렀는지 확인한다.(o)
    //3.누른 방향키의 방향대의 반대로 추력으로 날라가게 한다.(x)
    //- 위 아래만 정상 작동함 
    //- 왼쪽 오른쪽 동작하지 않음 이런 일단 정리 하고 다음에 수정하기로 함 

    public GameManager1 gameManager;

    private Rigidbody2D rb;
    private bool isGrounded; // 바닥 체크

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(gameManager.JumpConfirmation == true && gameManager.BullButtonAction == true)
        {
            Debug.Log("점프 상태 와 총알 발사 상태 확인");
            if(gameManager.BulletDirection == '\0' || gameManager.BulletDirection == 'R' )
            {
                
                //왼쪽으로 날아가기
                //무슨짓을해도 작동하지 않음 
            }
            else if(gameManager.BulletDirection == 'L' )
            {
              
                
                //오른쪽으로 날아가기
                //무슨짓을해도 작동하지 않음 
            }
            else if(gameManager.BulletDirection == 'U' )
            {
                //아래로 날아가기
                rb.velocity = new Vector2(rb.velocity.x,-10f);
            }
            else if(gameManager.BulletDirection == 'D' )
            {
                //위로 날아가기 
                rb.velocity = new Vector2(rb.velocity.x,10f);
            }
        }
    }

    
}
