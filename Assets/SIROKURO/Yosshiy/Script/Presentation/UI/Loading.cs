using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using DG.Tweening;
using System.Threading;
using System;

public class Loading : MonoBehaviour
{
    [SerializeField] Image Musk;
    [SerializeField] Image Icon;
    Sequence sequence;

    private void Start()
    {
        Observable.EveryUpdate()
            .Where(x => Input.GetKeyDown(KeyCode.Return))
            .Subscribe(x => Aa());
    }

    void Aa()
    {
        Musk.rectTransform
            .DOSizeDelta(new Vector2(0, 0), 1.5f)
            .SetEase(Ease.OutBounce)
            .OnComplete(() => Bb());
    }

    void Bb()
    {
        var y = 600;
        sequence.Join(Icon.rectTransform
            .DORotate(new Vector3(0, 0, 180), 1, RotateMode.FastBeyond360));
        sequence.Join(Icon.rectTransform
            .DOAnchorPosY(y, 1));
        sequence.Join(Icon.DOFade(0, 1));

    }
}
