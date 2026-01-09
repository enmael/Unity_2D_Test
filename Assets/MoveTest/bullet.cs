// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class bullet : MonoBehaviour
// {
//    public float bulletSpeed = 10f;
//     private Rigidbody2D rb;

//     void Awake()
//     {
//         rb = GetComponent<Rigidbody2D>();
//     }

//     // 오브젝트가 활성화(Active) 될 때마다 실행됨
//     void OnEnable()
//     {
//         // 1. 앞으로(오른쪽으로) 발사
//         rb.velocity = Vector2.right * bulletSpeed;

//         // 2. 1초 뒤에 비활성화 함수 호출
//         Invoke("Deactivate", 1.0f);
//     }

//     void Deactivate()
//     {
//         gameObject.SetActive(false);
//     }

//     // 만약 도중에 어디 부딪혀서 꺼질 때를 대비해 Invoke 취소
//     void OnDisable()
//     {
//         CancelInvoke();
//     }
// }
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameManager1 gameManager;
    private Rigidbody2D rb;

    int number = 0;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // 오브젝트가 활성화될 때 한 번 호출됩니다.
    void OnEnable()
    {
        if(gameManager.PlayerDirection.x == 1 && gameManager.PlayerDirection.y == 0){number = 0;}
        else if(gameManager.PlayerDirection.x == -1 && gameManager.PlayerDirection.y == 0){number = 1;}
        else if(gameManager.PlayerDirection.x == 0 && gameManager.PlayerDirection.y == 1){number = 2;}
        else if(gameManager.PlayerDirection.x == 0 && gameManager.PlayerDirection.y == -1  && gameManager.JumpConfirmation == true){number = 3;}

        if (rb != null)
        {
            StartDash(number);
        }
    }


    void StartDash(int number)
    {
        if(number == 0)
        {
            rb.velocity = new Vector2(1f, 0f)* gameManager.BulletSpped;
        }
        else if(number == 1)
        {
            rb.velocity = new Vector2(-1f, 0f)* gameManager.BulletSpped;
        }
        else if(number == 2)
        {
            rb.velocity = new Vector2(0f, 1f)* gameManager.BulletSpped;
        }
        else if(number == 3)
        {
            rb.velocity = new Vector2(0f, -1f)* gameManager.BulletSpped;
        }
        //rb.velocity = new Vector2(0f, 1f)* gameManager.BulletSpped;
    }
}