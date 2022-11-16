using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

public class PlayerPresenter : MonoBehaviour
{
    PlayerMover Mover;


    private void Awake()
    {
        Mover = GetComponent<PlayerMover>();

        Observable.EveryUpdate()
             .Where(x => Input.GetAxis("Horizontal") != 0)
             .Subscribe(x =>
             {
                 Mover.Move(2,Input.GetAxis("Horizontal"));
             });

        Observable.EveryUpdate()
             .Where(x => Input.GetKeyDown(KeyCode.Space))
             .Subscribe(x => Mover.Jump(5));
    }
}
