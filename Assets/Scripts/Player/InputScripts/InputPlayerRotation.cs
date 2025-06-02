using UnityEngine;

public class InputPlayerRotation : MonoBehaviour
{
    private float _slerpCorrectionValue = 5.0f; //Slerp�̕⊮�l

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
    }

    private void FixedUpdate()
    {
        //��]����
        _playerRotation = new Vector3(_horizontal, 0, _vertical).normalized;
        //�v���C���[�̉�]��LookAt�n�_�ɐݒ�A�����Quaternion�ɔ��f
        Quaternion targetRotation = Quaternion.LookRotation(_playerRotation);
        //Slerp�łȂ߂炩�ɉ�]������B�Ȃ��A���͂��������͎����I�Ɍ��̊p�x�ɖ߂�
        transform.rotation = Quaternion.Slerp(this.transform.rotation,targetRotation, _slerpCorrectionValue);
    }
}
