using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayerObjectGet : MonoBehaviour
{
    [Header("���X�N���v�g�擾�p")]
    [SerializeField] private CatchTheObject _catchTheObject = default;

    private readonly string CATCHBUTTONNAME = "Catch"; //���{�^���̕ϐ���

    //�I�u�W�F�N�g�������Ă邩�ǂ����A�����Ă��瓊����X�N���v�g�ɖ��߂���
    private bool _isHaveingObject = false; 
    private void Update()
    {
        bool canCatch = Input.GetButtonDown(CATCHBUTTONNAME) && !_isHaveingObject;
        if (canCatch)
        {
            _catchTheObject.CatchProtocol();
        }
    }
}
