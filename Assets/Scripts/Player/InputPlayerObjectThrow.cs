using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayerObjectThrow : MonoBehaviour
{
    [Header("���X�N���v�g�擾�p")]
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
            Debug.Log("������");
            _throwObject.ObjectThrow(_catchTheObject.HavingObject);
        }
    }
}
