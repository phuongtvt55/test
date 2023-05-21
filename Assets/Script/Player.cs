using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{
    public string name;
    public float speed;
    public float jumpPower;


    public Player(string name, float speed, float jump)
    {
        this.name = name;
        this.speed = speed;
        this.jumpPower = jump;
    }
}
