using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputThrowObject : MonoBehaviour
{
    [Header("他スクリプト取得用")]
    [SerializeField] private ThrowProtocol _throwObject = default;
    [SerializeField] private InputGetObject _inputObjectGet = default;
    [SerializeField] private CatchProtocol _catchTheObject = default;

    private readonly string THROWBUTTONNAME = "Catch";

    private bool _canThrow = false;

    private void Update()
    {
        _canThrow = Input.GetButtonDown(THROWBUTTONNAME) && _inputObjectGet.PlayerState == PlayerState.Having;

        if (_canThrow)
        {
            Debug.Log("投げた");
            _throwObject.ThrowMethod(_catchTheObject.HavingObject);
        }
    }
}
