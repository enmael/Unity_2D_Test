#region 원본 코드 
/*
using UnityEngine;
using System.Collections;

public class SmoothMovement : MonoBehaviour
{
    private bool isMoving = false; // 이동 중복 방지

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !isMoving)
        {
            // 목표 지점 계산: 현재 위치 + 위로 10
            Vector3 targetPos = transform.position + new Vector3(0, 10, 0);
            StartCoroutine(MoveToPosition(targetPos, 0.5f)); // 0.5초 동안 이동
        }
    }

    IEnumerator MoveToPosition(Vector3 target, float duration)
    {
        isMoving = true;
        Vector3 startPos = transform.position;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            // Lerp를 사용하여 부드러운 보간 이동
            transform.position = Vector3.Lerp(startPos, target, elapsed / duration);
            elapsed += Time.deltaTime;
            
            // 실시간 좌표 출력
            Debug.Log($"이동 중... 현재 Y: {transform.position.y:F2}");
            yield return null;
        }

        transform.position = target;
        isMoving = false;
        Debug.Log("이동 완료!");
    }
}
*/
#endregion

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerContorlsDubleeJump : MonoBehaviour
{
    public GameManager2 gameManager;

     private bool isMoving = false; // 이동 중복 방지
    void Update()
    {
        Vector3 targetPos = transform.position;
        if (Input.GetKeyDown(KeyCode.X) && gameManager.PlayerisJumping == true && !isMoving)
        {
            if(gameManager.PlayerDirection == 'R')
            {
                targetPos = transform.position + new Vector3(-4, 0, 0);
            }
            else if(gameManager.PlayerDirection == 'L')
            {
                targetPos = transform.position + new Vector3(4, 0, 0);
            }
            else if(gameManager.PlayerDirection == 'U')
            {
                targetPos = transform.position + new Vector3(0, -4, 0);
            }
            else if(gameManager.PlayerDirection == 'D')
            {
                targetPos = transform.position + new Vector3(0, 4, 0);
            }
            StartCoroutine(MoveToPosition(targetPos, 0.3f)); // 0.5초 동안 이동
        }
    }

    IEnumerator MoveToPosition(Vector3 target, float duration)
    {
        isMoving = true;
        Vector3 startPos = transform.position;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            // Lerp를 사용하여 부드러운 보간 이동
            transform.position = Vector3.Lerp(startPos, target, elapsed / duration);
            elapsed += Time.deltaTime;
            
            // 실시간 좌표 출력
            //Debug.Log($"이동 중... 현재 Y: {transform.position.y:F2}");
            yield return null;
        }

        transform.position = target;
        isMoving = false;
        //Debug.Log("이동 완료!");
    }
}