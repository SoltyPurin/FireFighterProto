using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendObjectProtocol : MonoBehaviour
{
    [Header("���X�N���v�g�擾")]
    //�{�b�N�X�R���C�_�[�𕪂��邽�߂�closetObject�ɏ��𑗂�
    [SerializeField] private CatchProtocol _catchProtocol = default; 
    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage"))
        {
            _catchProtocol.ClosetObject = collision.gameObject;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage"))
        {
            _catchProtocol.ClosetObject = null;
        }

    }

}
