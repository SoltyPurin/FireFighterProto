using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayerObjectThrow : MonoBehaviour
{
    [Header("他スクリプト取得用")]
    [SerializeField] private ThrowObject _throwObject = default;
    [SerializeField] private InputPlayerObjectGet _inputObjectGet = default;
    [SerializeField] private CatchTheObject _catchTheObject = default;

    private readonly string THROWBUTTONNAME = "Catch";

    private bool _canThrow = false;

    private void Update()
    {
        _canThrow = Input.GetButtonDown(THROWBUTTONNAME) && _inputObjectGet.PlayerState == PlayerState.Having;

        if (_canThrow)
        {
            Debug.Log("投げた");
            _throwObject.ObjectThrow(_catchTheObject.HavingObject);
        }
    }
}
