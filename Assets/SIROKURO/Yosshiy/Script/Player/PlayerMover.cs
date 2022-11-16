using System.Collections;
using System.Collections.Generic;
using UnityEngine;

sealed class PlayerMover : BasePlayer
{
    Rigidbody2D PlayerRb;

    protected override void OnInitialize()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    public void Move(float speed,Vector2 direction)
    {
        PlayerRb.AddForce(direction);
    }

    public void Jump(float jump)
    {
        PlayerRb.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);
    }
}
