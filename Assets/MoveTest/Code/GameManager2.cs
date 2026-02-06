using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    [Header("플레이어 관련")]
    [SerializeField]public GameObject player;

    [SerializeField]public float playerSpeed = 5f;
    [SerializeField] public char playerDirection = ' ';

    [SerializeField] public bool playerisJumping = false;

    public GameObject Player
    {
        get{return player;}
        set{player = value;}
    }

    public float PlayerSpeed
    {
        get{return playerSpeed;}
        set{playerSpeed = value;}
    }

    public char PlayerDirection
    {
        get{return playerDirection;}
        set{playerDirection = value;}
    }

    public bool PlayerisJumping
    {
        get{return playerisJumping;}
        set{playerisJumping = value;}
    }
}
