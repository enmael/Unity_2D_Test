using UnityEngine;

public class CameraFollowLerp : MonoBehaviour
{
    [SerializeField] Transform target;
    public float lerpSpeed = 5f; // 따라가는 속도
    public Vector3 offset; //(0,0, -10)

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            
            // 현재 위치와 목표 위치 사이를 lerpSpeed의 속도로 부드럽게 연결
            transform.position = Vector3.Lerp(transform.position, targetPosition, lerpSpeed * Time.deltaTime);
        }
    }
}