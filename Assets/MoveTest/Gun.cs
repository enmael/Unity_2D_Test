using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //  public GameManager1 gameManager;

    // public int number = 0;
    // [SerializeField]private float nextFireTime = 0.0f;

    // private Rigidbody2D rb;
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    // }
    // void Update()
    // {

    //     float inputX = Input.GetAxisRaw("Horizontal");
    //     float inputY = Input.GetAxisRaw("Vertical");
        
    //     if (inputX != 0 || inputY != 0)
    //     {
    //         gameManager.PlayerDirection =  new Vector2(inputX, inputY).normalized;
    //     }

    //     if (Input.GetKeyDown(KeyCode.X))
    //     {
    //         if (Time.time >= nextFireTime)
    //         {
    //         // 3. 발사 가능! 다음 발사 시간을 현재 시간 + 딜레이로 설정
    //         nextFireTime = Time.time + gameManager.BullseTime;

    //         gameManager.BulletArray[number].transform.position = gameManager.Player.transform.position;
    //         gameManager.BulletArray[number].SetActive(true);
    //         number++;
    //         }

    //         if(gameManager.PlayerDirection.x == 0 && gameManager.PlayerDirection.y == -1  && gameManager.JumpConfirmation == true)
    //         {
    //             rb.velocity = new Vector2(rb.velocity.x, gameManager.PlayerJumpForce);
    //         }

            
    //     }

    //     if(number == 5)
    //     {
    //         number = 0;
    //     }

        
    // }

    public GameManager1 gameManager;

    void Update()
    {
        // 1. 방향키 입력 받기
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 fireDir = new Vector2(h, v);

        // 2. x키 누르면 공격이다 
        if (Input.GetKeyDown(KeyCode.X))
        {
            // 입력이 없으면(0,0) 기본적으로 오른쪽으로 발사
            if (fireDir == Vector2.zero) fireDir = Vector2.right;

            Shoot(fireDir);
        }
    }

    void Shoot(Vector2 dir)
    {
       gameManager.Bullet.SetActive(true);
       
    }
}
