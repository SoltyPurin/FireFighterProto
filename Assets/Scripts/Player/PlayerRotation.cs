using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{


    private Vector3 _playerRotation = default; //��]�����̓��ꕨ

    private readonly string HORIZONTALNAME = "Horizontal";   //�����̖��O�ϐ�
    private readonly string VERTICALNAME = "Vertical";       //�����̖��O�ϐ�

    private float _horizontal = default;                     //�����̓��͒l�̓��ꕨ
    private float _vertical = default;                       //�����̓��͒l�̓��ꕨ

    private void Update()
    {
        //�����̓��͒l����
        _horizontal = Input.GetAxis(HORIZONTALNAME);
        //�����̓��͒l����
        _vertical = Input.GetAxis(VERTICALNAME) ;
        _playerRotation = new Vector3(_horizontal, 0, _vertical).normalized;
    }

    private void FixedUpdate()
    {
        Quaternion targetRotation = Quaternion.LookRotation(_playerRotation);
        transform.rotation = Quaternion.Slerp(this.transform.rotation,targetRotation,5);
    }
}
