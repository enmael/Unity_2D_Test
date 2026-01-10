/*
    생성일자 : 2026.01.10
    파일이름 : RotationFixed.cs
    생성자:
    내용: 부모 오브젝트가 돌아가든 말든 회전값(rotation)을 고정하는 코드
*/
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
