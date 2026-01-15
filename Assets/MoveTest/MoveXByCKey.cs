using UnityEngine;

public class MoveXByCKey : MonoBehaviour
{
    public float moveDistance = 5f; // 한 번에 이동할 거리
    public float moveSpeed = 10f;  // 이동 속도 (높을수록 빠름)

    private Vector3 targetPosition; // 이동 목표 지점
    private bool isMoving = false;  // 현재 이동 중인지 확인

    void Start()
    {
        // 시작 시 현재 위치를 목표 지점으로 설정
        targetPosition = transform.position;
    }

    void Update()
    {
        // 1. C 키를 눌렀을 때 목표 지점 갱신
        // (이동 중에도 누르면 더 멀리 가도록 하려면 isMoving 체크를 빼면 됩니다)
        if (Input.GetKeyDown(KeyCode.C))
        {
            targetPosition += new Vector3(moveDistance, 0, 0);
            isMoving = true;
        }

        // 2. 현재 위치에서 목표 위치까지 부드럽게 이동
        if (isMoving)
        {
            // MoveTowards는 일정한 속도로 목표 지점까지 이동시켜 줍니다.
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // 목표 지점에 거의 도착했다면 이동 종료
            if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
            {
                transform.position = targetPosition; // 정확한 위치로 고정
                isMoving = false;
            }
        }
    }
}
