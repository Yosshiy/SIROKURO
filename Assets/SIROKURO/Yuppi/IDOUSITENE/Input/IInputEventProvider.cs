using UniRx;
using UnityEngine;

public interface IInputEventProvider
{
    IReactiveProperty<bool> Action { get; }
    IReactiveProperty<bool> Jump { get; }
    IReactiveProperty<Vector2> Direction { get; }
}
