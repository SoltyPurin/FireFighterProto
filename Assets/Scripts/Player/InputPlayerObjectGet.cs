using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    None,
    Having
}
public class InputPlayerObjectGet : MonoBehaviour
{
    [Header("���X�N���v�g�擾�p")]
    [SerializeField] private CatchTheObject _catchTheObject = default;
    [SerializeField] private ThrowObject _throwObject = default;

    private readonly string CATCHBUTTONNAME = "Catch"; //���{�^���̕ϐ���

    private PlayerState _playerState = PlayerState.None;
    public PlayerState PlayerState
    {
        set { _playerState = value; }
    }
    //�I�u�W�F�N�g�������Ă邩�ǂ���
    private bool _isHavingObject = false;

    //�I�u�W�F�N�g�����邩�ǂ���
    private bool _canCatch = false;
    //�I�u�W�F�N�g�𓊂����邩�ǂ���
    private bool _canThrow = false;
    private void Update()
    {
        //�I�u�W�F�N�g����������true�ɂȂ�
        _isHavingObject = _catchTheObject.HavingObject != null;
        //�{�^�����������Ƃ��ɋ߂��ɃI�u�W�F�N�g�������āA������bool��false�̎���true
        _canCatch = Input.GetButtonDown(CATCHBUTTONNAME) && _playerState == PlayerState.None;
        //�{�^�����������Ƃ��ɃI�u�W�F�N�g�������Ă���true
        _canThrow = Input.GetButtonDown(CATCHBUTTONNAME) && _playerState == PlayerState.Having;

        if (_canCatch)
        {
            Debug.Log("�L���b�`");
            _catchTheObject.CatchProtocol();
        }else if (_canThrow)
        {
            Debug.Log("�����[�X");
            _throwObject.ObjectThrow(_catchTheObject.ClosetObject);
        }
    }
}
