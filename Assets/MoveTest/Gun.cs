/*
    생성일자 : 2026.01.16
    파일이름 : Gun.cs
    생성자: enmael
    내용: 플레이어 캐릭터 위에 키보드 방향으로 총알이 발사되는 위치값을 총알에게 수신하는 코드이다.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameManager1 gameManager;

    //1.총알의 방향을 수신하고 그걸 총알에게 넘겨서 x키 누를때마다 발사시키는 기능 
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Direction(v,h);


        // X키 점프
        if (Input.GetKeyDown(KeyCode.X) && gameManager.Bullet.activeSelf == false)
        {
            gameManager.Bullet.transform.position = transform.position;
            gameManager.Bullet.SetActive(true);
            gameManager.BullButtonAction = true;
        }
        
    }

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
                    gameManager.BulletDirection = 'R';
                }
                else
                {
                    Debug.Log("현재 방향: 왼쪽 (Left)");
                    gameManager.BulletDirection = 'L';
                }
            }
            else
            {
                // 상하 방향 체크
                if (v > 0)
                {
                    Debug.Log("현재 방향: 위쪽 (Up)");
                    gameManager.BulletDirection = 'U';
                }
                else
                {
                    Debug.Log("현재 방향: 아래쪽 (Down)");
                    gameManager.BulletDirection = 'D';
                }
            }
        }
        
    }

}
