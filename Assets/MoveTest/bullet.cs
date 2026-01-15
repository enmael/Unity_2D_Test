/*
    생성일자 : 2026.01.16
    파일이름 : bullet.cs
    생성자: enmael
    내용: 총알이 방향을 수신해서 발사되고 일정 시간후 비활성화 되는 코드 
*/
using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class bullet : MonoBehaviour
{
    //총알의 방향을 수신하는 코드
    //총알이 수신한 방향을 가지고 발사되는 코드

    public GameManager1 gameManager;
    private Rigidbody2D rb;

    private Coroutine disableCoroutine; // 코루틴을 제어하기 위한 변수

    //1. 방향을 수신해서 총알을 원하는 방향으로 발사 
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {   
        SetDirection();

        // 이미 실행 중인 코루틴이 있다면 정지 (중복 방지)
        if (disableCoroutine != null)
        {
            StopCoroutine(disableCoroutine);
        }
        
        // 켜질 때마다 타이머 시작
        disableCoroutine = StartCoroutine(Disablebullets(gameManager.BullseTime));
    }

    void SetDirection()
    {
       if(gameManager.BulletDirection == '\0' || gameManager.BulletDirection == 'R' )
        {
            rb.velocity = Vector2.right * gameManager.BulletSpped; 
        }
        else if(gameManager.BulletDirection == 'L' )
        {
            rb.velocity = Vector2.left * gameManager.BulletSpped;
        }
        else if(gameManager.BulletDirection == 'U' )
        {
            rb.velocity = Vector2.up * gameManager.BulletSpped; 
        }
        else if(gameManager.BulletDirection == 'D' )
        {
            rb.velocity = Vector2.down * gameManager.BulletSpped;
        }
    }

    //2. 시간 지나면 자동으로 비활성화 (o)
    IEnumerator Disablebullets(float time)
    {
        yield return new WaitForSeconds(time);
        gameManager.BullButtonAction = false;
        gameManager.Bullet.SetActive(false);
    }

    // 화면 밖으로 나가면 비활성화 (선택 사항)
    // void OnBecameInvisible()
    // {
    //     gameObject.SetActive(false);
    // }
}