using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Title_UI : MonoBehaviour
{
    [SerializeField] Image UnMask;
    [SerializeField] Image Circle;
    [SerializeField] Image Kasa;
    [SerializeField] Image Fuurin;
    [SerializeField] Image Fuurin2;

    private void Start()
    {
        var pos = Circle.rectTransform.localScale * 1.8f;
        UnMask.rectTransform.DOScale(pos * 1.1f, 3).SetLoops(-1,LoopType.Restart).SetEase(Ease.InOutQuad);
        Circle.rectTransform.DOScale(pos, 3).SetLoops(-1,LoopType.Restart).SetEase(Ease.InOutQuad);


        Kasa.rectTransform
            .DORotate(new Vector3(0, 0, 360), 3,RotateMode.FastBeyond360)
            .SetLoops(-1,LoopType.Restart)
            .SetEase(Ease.Linear);

        Fuurin.rectTransform
            .DORotate(new Vector3(0, 0, 10), 2.3f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutQuad);

        Fuurin2.rectTransform
            .DORotate(new Vector3(0, 0, -10), 1.8f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutQuad);

    }

     
}
