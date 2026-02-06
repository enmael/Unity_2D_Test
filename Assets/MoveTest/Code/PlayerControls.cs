/*
    생성일자 : 2026.01.28
    파일이름 : PlayerControls.cs
    생성자: enmael
    내용: 좌우이동,방향키의방향,캐릭터 오브젝트의 좌우 반전이 포함된 코드이다 .
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameManager2 gameManager;
    //[SerializeField] private float moveSpeed = 5f; // 이동 속도
    [SerializeField] char direction = ' '; 

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Reversal(h);
        Direction(v,h);

        //좌우 조작 코드
        Vector2 moveDirection = new Vector2(h, 0).normalized;

        // transform.Translate(이동방향 * 속도 * 프레임보정, 기준좌표)
        transform.Translate(moveDirection * gameManager.PlayerSpeed * Time.deltaTime, Space.World);
    }

// 캐릭터의 반전 코드 
    private void Reversal(float number)
    {

         if(number > 0 )
        {
            transform.localScale = new Vector2(-5.0f, transform.localScale.y);
        }
        else if(number < 0)
        {
            transform.localScale = new Vector2(5.0f, transform.localScale.y);
        }
        
    }

//방향인식 코드
    private void Direction(float v, float h)
    {
        if (h != 0 || v != 0)
        {
            //절대값을 비교하여 좌우 입력이 더 큰지, 상하 입력이 더 큰지 판단
            if (Mathf.Abs(h) >= Mathf.Abs(v))
            {
                // 좌우 방향 체크
                if (h > 0)
                {
                    Debug.Log("현재 방향: 오른쪽 (Right)");
                    gameManager.PlayerDirection = 'R';
                }
                else
                {
                    Debug.Log("현재 방향: 왼쪽 (Left)");
                    gameManager.PlayerDirection= 'L';
                }
            }
            else
            {
                // 상하 방향 체크
                if (v > 0)
                {
                    Debug.Log("현재 방향: 위쪽 (Up)");
                    gameManager.PlayerDirection = 'U';
                }
                else
                {
                    Debug.Log("현재 방향: 아래쪽 (Down)");
                    gameManager.PlayerDirection = 'D';
                }
            }
        }
        
    }
}
