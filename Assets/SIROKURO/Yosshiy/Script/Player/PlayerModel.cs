using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace Player.Model
{
    public class PlayerModel
    {

        public readonly IObservable<long> _UpdateObservable = Observable.EveryUpdate();
        public float Speed { get { return _Speed; } set { _Speed = value; } }
        public float JumpPower { get { return _JumpPower; } set { _JumpPower = value; } }

        private float _Speed = 3.5f;
        private float _JumpPower = 6;

    }

}
