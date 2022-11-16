using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Reverse : MonoBehaviour
{
    [SerializeField] GameObject Siro;
    [SerializeField] GameObject Kuro;

    private void Awake()
    {
        Kuro.SetActive(false);

        Observable.EveryUpdate()
            .Where(x => Input.GetKeyDown(KeyCode.Return))
            .Subscribe(x => Reversible());
    }

    private void Reversible()
    {
        Kuro.SetActive(!Kuro.activeSelf);
        Siro.SetActive(!Siro.activeSelf);
    }
}
