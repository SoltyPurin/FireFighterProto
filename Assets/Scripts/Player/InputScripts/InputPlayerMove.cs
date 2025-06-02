using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayerMove : MonoBehaviour
{
    [Header("�擾�p�̕ϐ�")]
    [SerializeField] private Rigidbody _rigidBody = default; //�ړ��p��rigidbody�擾
    [Header("���x����")]
    [SerializeField] private float _moveSpeedMultiplier = 0.5f; //���x�𒲐�����p�̐���

    private readonly string HORIZONTALNAME = "Horizontal";   //�����̖��O�ϐ�
    private readonly string VERTICALNAME = "Vertical";       //�����̖��O�ϐ�

    private float _horizontal = default;                     //�����̓��͒l�̓��ꕨ
    private float _vertical = default;                       //�����̓��͒l�̓��ꕨ
    private void Update()
    {
        //�����̓��͒l�����B�����đ�������̂Ō���
        _horizontal = Input.GetAxis(HORIZONTALNAME) * _moveSpeedMultiplier;
        //�����̓��͒l�����B�����đ�������̂Ō���
        _vertical = Input.GetAxis(VERTICALNAME) * _moveSpeedMultiplier;             
    }

    private void FixedUpdate()
    {
        _rigidBody.position += new Vector3(_horizontal, 0, _vertical); //�ړ�����
    }
}
