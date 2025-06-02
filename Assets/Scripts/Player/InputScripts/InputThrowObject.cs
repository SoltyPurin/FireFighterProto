using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputThrowObject : MonoBehaviour
{
    [Header("���X�N���v�g�擾�p")]
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
            Debug.Log("������");
            _throwObject.ThrowMethod(_catchTheObject.HavingObject);
        }
    }
}
