using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetected : MonoBehaviour
{
    [Header("���X�N���v�g�擾")]
    [SerializeField] private InputJump _inputJump = default;

    private void OnTriggerEnter(Collider other)
    {
        //�n�ʂɂ��Ă���IsDetectedGround��true�ɂ���
        _inputJump.IsDetectedGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //�n�ʂ��痣�ꂽ��IsDetectedGround��false�ɂ���
        _inputJump.IsDetectedGround = false;
    }
}
