// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerContorlsJump : MonoBehaviour
// {
//  private bool isGrounded; // 바닥 체크

//     [SerializeField] private float gravity = -9.81f; // 중력 강도 (숫자가 낮을수록 빠르게 추락)
    
//     private float verticalVelocity = 0f; // 현재 수직 속도

//     Vector3 targetPos;
//     float lerpSpeed = 5f;

//     void Update()
//     {

//         //리지드 바디 없이 추락하는 기능 
//         if(isGrounded == false)
//         {
//         // 1. 매 프레임마다 중력값을 수직 속도에 누적 (속도가 점점 빨라짐)
//         verticalVelocity += gravity * Time.deltaTime;

//         // 2. 계산된 속도를 캐릭터 위치에 적용
//         // Vector3.up(0, 1, 0)에 속도를 곱해 수직으로 이동시킴
//         transform.Translate(Vector3.up * verticalVelocity * Time.deltaTime);
//         }
      
//     }
// //바닥 인식 기능  
//     void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.collider.CompareTag("Ground"))
//         {
//             Debug.Log("바닥잇다");
//             isGrounded = true;
//         }
//     }

//     void OnCollisionExit2D(Collision2D collision)
//     {
//         if (collision.collider.CompareTag("Ground"))
//         {
//             Debug.Log("바닥없다");
//             isGrounded = false;
//         }
//     }
// //점프
// }
using System.Collections;
using UnityEngine;

public class PlayerContorlsJump : MonoBehaviour
{
    public GameManager2 gameManager;
    private bool isGrounded = false;
    //private bool isJumping = false;

    [SerializeField] private float gravity = -30f; // 중력 (값 클수록 빨리 떨어짐)
    private float verticalVelocity = 0f;

    [Header("Jump Settings")]
    public float jumpHeight = 10f;
    public float jumpDuration = 0.2f;

    void Update()
    {
        // Z 키 점프
        if (Input.GetKeyDown(KeyCode.Z) && isGrounded && !gameManager.PlayerisJumping)
        {
            StartCoroutine(JumpCoroutine());
        }

        // 리지드바디 없이 중력 적용
        if (!isGrounded && !gameManager.PlayerisJumping)
        {
            verticalVelocity += gravity * Time.deltaTime;
            transform.Translate(Vector3.up * verticalVelocity * Time.deltaTime);
        }
    }

    IEnumerator JumpCoroutine()
    {
        gameManager.PlayerisJumping = true;
        isGrounded = false;
        verticalVelocity = 0f;

        Vector3 start = transform.position;
        Vector3 end = start + Vector3.up * jumpHeight;

        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / jumpDuration;
            transform.position = Vector3.Lerp(start, end, t);
            yield return null;
        }

        transform.position = end;
        gameManager.PlayerisJumping = false;
    }

    // 바닥 체크
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
            verticalVelocity = 0f;
            Debug.Log("바닥 있다");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
            Debug.Log("바닥 없다");
        }
    }
}
