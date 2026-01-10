/*
    생성일자 : 2026.01.10
    파일이름 : CameraFollowLerp.cs
    생성자:
    내용: 카메라 오브젝트가 지정한 오브젝트를 따라가게 하는 코드이다.
*/
using UnityEngine;
public class CameraFollowLerp : MonoBehaviour
{

    public GameManager1 gameManager;
    public float lerpSpeed = 5f; // 따라가는 속도
    public Vector3 offset; //(0,0, -10)

    void LateUpdate()
    {
        if (gameManager.Player.transform != null)
        {
            Vector3 targetPosition = gameManager.Player.transform.position + offset;
            
            // 현재 위치와 목표 위치 사이를 lerpSpeed의 속도로 부드럽게 연결
            transform.position = Vector3.Lerp(transform.position, targetPosition, lerpSpeed * Time.deltaTime);
        }
    }
}