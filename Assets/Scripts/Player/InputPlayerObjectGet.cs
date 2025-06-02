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

    private readonly string CATCHBUTTONNAME = "Catch"; //���{�^���̕ϐ���

    private PlayerState _playerState = PlayerState.None;
    public PlayerState PlayerState
    {
        set { _playerState = value; } //CatchTheObject�X�N���v�g���珑������
        get { return _playerState; } //InputPlayerObjectThrow����Q��
    }

    //�I�u�W�F�N�g�����邩�ǂ���
    private bool _canCatch = false;
    private void Update()
    {
        //�{�^�����������Ƃ��ɋ߂��ɃI�u�W�F�N�g�������āA������bool��false�̎���true
        _canCatch = Input.GetButtonDown(CATCHBUTTONNAME) && _playerState == PlayerState.None;

        if (_canCatch)
        {
            Debug.Log("�L���b�`");
            _catchTheObject.CatchProtocol();
        }
    }
}
