/*
    생성일자 : 2026.01.10
    파일이름 : GameManager1.cs
    생성자:
    내용: 게임
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
     [Header("플레이어")]
    [SerializeField] public GameObject player;

    [SerializeField] public float playerMoveSpeed = 3f;
    [SerializeField] public float playerJumpForce = 14f;
    [SerializeField] public bool jumpConfirmation = false;
    [SerializeField] Vector2 playerDirection;

    [Header("총알코드")]
    [SerializeField] public GameObject bullet;
    [SerializeField] public float bulletSpped = 10f;
    [SerializeField] float bullseTime = 0;
    [SerializeField] char bulletDirection;

    [SerializeField] bool bullButtonAction = false;

    public GameObject Player
    {
        get{return player;}
        set{player = value;}
    }


    public float PlayerMoveSpeed
    {
        get { return playerMoveSpeed; }
        set { playerMoveSpeed = value; }
    }

    public float PlayerJumpForce
    {
        get { return playerJumpForce; }
        set { playerMoveSpeed = value; }
    }

    public  bool JumpConfirmation
    {
        get { return jumpConfirmation; }
        set { jumpConfirmation = value; }
    }

    public float BulletSpped
    {
        get{return bulletSpped;}
        set{bulletSpped = value;}
    }

    public Vector2 PlayerDirection
    {
        get{return playerDirection;}
        set{playerDirection = value;}
    }

    public  float BullseTime
    {
        get{return bullseTime;}
        set{bullseTime = value;}
    }

    public GameObject Bullet
    {
        get{return bullet;}
        set{bullet = value;}
    }

    public char BulletDirection
    {
        get{return bulletDirection;}
        set{bulletDirection = value;}
    }

    public bool BullButtonAction
    {
        get{return bullButtonAction;}
        set{bullButtonAction = value;}
    }


}
