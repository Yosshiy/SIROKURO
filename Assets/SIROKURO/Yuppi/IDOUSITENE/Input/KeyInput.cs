using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public sealed class KeyInput : IInputEventProvider
{
    IReactiveProperty<bool> IInputEventProvider.Action => _Action;
    IReactiveProperty<bool> IInputEventProvider.Jump => _Jump;
    IReactiveProperty<Vector2> IInputEventProvider.Direction => _Direction;

    ReactiveProperty<bool> _Action = new ReactiveProperty<bool>();
    ReactiveProperty<bool> _Jump = new ReactiveProperty<bool>();
    ReactiveProperty<Vector2> _Direction = new ReactiveProperty<Vector2>();

    const KeyCode ActionKey = KeyCode.Return;
    const KeyCode JumpKey = KeyCode.Space;

    KeyInput()
    {
        Observable.EveryUpdate()
            .Select(x => Input.GetKeyDown(JumpKey))
            .DistinctUntilChanged()
            .Subscribe(x => _Jump.Value = x);

        Observable.EveryUpdate()
            .Select(x => new Vector2(Input.GetAxis("Horizontal"),0))
            .Subscribe(x => _Direction.SetValueAndForceNotify(x));
    }

}
