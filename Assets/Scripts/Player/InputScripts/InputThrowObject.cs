using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputThrowObject : MonoBehaviour
{
    [Header("���X�N���v�g�擾�p")]
    [SerializeField] private ThrowProtocol _throwObject = default;
    [SerializeField] private InputGetObject _inputObjectGet = default;
    [SerializeField] private CatchProtocol _catchTheObject = default;

    private readonly string THROWBUTTONNAME = "Catch";�@//catch�{�^���̖��O��ۑ�����ϐ��A������̂ƏE���͓̂����{�^��

    private bool _canThrow = false; //�������邩�ǂ����B�ŏ��͂Ȃɂ������ĂȂ����ߓ������Ȃ��̂�false

    private void Update()
    {
        //Throw�{�^����������ĂȂ����v���C���[�̃X�e�[�g��Having(�I�u�W�F�N�g�������Ă���)��Ԃł���Γ�������
        _canThrow = Input.GetButtonDown(THROWBUTTONNAME) && _inputObjectGet.PlayerState == PlayerState.Having;

        if (_canThrow)
        {
            //�����閽�߂��o��
            _throwObject.ThrowMethod(_catchTheObject.HavingObject);
        }
    }
}
