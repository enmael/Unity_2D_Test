using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationFixed : MonoBehaviour
{
void LateUpdate()
{
    // 부모의 회전과 상관없이 월드 기준 0으로 고정
    transform.rotation = Quaternion.Euler(0, 0, 0);
}
}
