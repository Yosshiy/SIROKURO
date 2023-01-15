using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;
using Zenject;
using Player.Model;

public class PlayerPresenter : MonoBehaviour
{
    PlayerMover Mover;
    PlayerModel Model;
    [Inject]
    readonly IInputEventProvider MyInput;

    private void Awake()
    {
        Mover = GetComponent<PlayerMover>();
        Model = new PlayerModel();

        MyInput.Direction
             .Subscribe(x =>
             {
                 Mover.Move(Model.Speed,x);
             });

        MyInput.Jump
            .Where(x => x == true)
            .Subscribe(x => Mover.Jump(Model.JumpPower));
    }
}
