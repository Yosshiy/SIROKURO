using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : BasePlayer
{
    Rigidbody2D PlayerRb;

    protected override void OnInitialize()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    public void Move(float speed, float intensity_x)
    {
        var newvector = Vector2.right * intensity_x;
        PlayerRb.velocity = newvector.normalized * speed;
    }

    public void Jump(float jump)
    {
        PlayerRb.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);
    }
}
