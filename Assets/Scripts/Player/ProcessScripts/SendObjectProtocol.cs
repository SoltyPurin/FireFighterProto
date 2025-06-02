using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendObjectProtocol : MonoBehaviour
{
    [Header("���X�N���v�g�擾")]
    //�{�b�N�X�R���C�_�[�𕪂��邽�߂�closetObject�ɏ��𑗂�
    [SerializeField] private CatchProtocol _catchProtocol = default;
    [SerializeField] private ColorChangeClosetObjectProtocol _colorChangeProtocol = default; //���F�ւ��E�G�̃X�N���v�g
    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage")) //�X�e�[�W�̃^�O�����Ă镨�ȊO�������玝�Ă�悤�ɂ���
        {
            _catchProtocol.ClosetObject = collision.gameObject; //��ԋ߂��I�u�W�F�N�g��Closet�I�u�W�F�N�g�ɑ������
            _colorChangeProtocol.ChangeColor(collision.gameObject); //���F�ւ��E�G
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage")) //�X�e�[�W�̃^�O�����Ă镨�ȊO�������ꍇ�����𑱍s
        {
            _catchProtocol.ClosetObject = null; //ClosetObject�̒��g������
            _colorChangeProtocol.ReturnColor(collision.gameObject);//�F�߂��E�G

        }

    }

}
