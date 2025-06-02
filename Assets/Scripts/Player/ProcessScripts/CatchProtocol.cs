using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchProtocol : MonoBehaviour
{
    [Header("�擾�p")]
    [SerializeField] private InputGetObject _inputObjectGet = default;

    [Header("�߂��ɂ���I�u�W�F�N�g�̏�񂪓���̂ŃC���X�y�N�^�[�ł͓���Ȃ�")]
    [SerializeField] private GameObject _closetObject = default; //�߂��ɂ���I�u�W�F�N�g

    public GameObject ClosetObject
    {
        set { _closetObject = value; } //SendObjectProtocol�ɂ��set���A�����󂯎��
    }
    [SerializeField] private GameObject _havingObject = default;//�擾�����I�u�W�F�N�g

    public GameObject HavingObject
    {
        get { return _havingObject; } //�����Ă���I�u�W�F�N�g�𑼃X�N���v�g����Q�Ƃł���悤�ɂ���
    }


    public void CatchMethod()
    {
        if(_closetObject == null)
        {
            return; //�߂��ɕ����Ȃ��ꍇ��return
        }
        _havingObject = _closetObject; //�߂��ɂ���(closet)�I�u�W�F�N�g���玝���Ă�(Having)�I�u�W�F�N�g�ɂ���
        _closetObject = null; //�߂��ɂ���I�u�W�F�N�g��null�ɂ���
        StartCoroutine(ChangeState()); //�����ŃX�e�[�g�ύX�̏����𑖂点��
        _havingObject.transform.SetParent(this.transform); //�v���C���[�̎q�I�u�W�F�N�g�ɂ���
        Vector3 initClosetObjectPosition = _havingObject.transform.position; //���̃I�u�W�F�N�g�̍��W���擾
        initClosetObjectPosition.y += 0.5f; //���������グ��A��������Ȃ��ƋC�����悭�������Ȃ�
        _havingObject.transform.position = initClosetObjectPosition; //�����グ����̍��W�𔽉f
        Rigidbody havingObjectRigidBody = _havingObject.GetComponent<Rigidbody>(); //�I�u�W�F�N�g��rigidbody���擾
        BoxCollider havingObjectBoxCollider = _havingObject.GetComponent<BoxCollider>(); //boxCollider���擾
        havingObjectBoxCollider.enabled = false; //boxCollider�𖳌������A�Ђ�������Ȃ�����
        havingObjectRigidBody.isKinematic = true;//isKinematic��true�ɂ��A���������𖳌�������
    }

    private IEnumerator ChangeState()
    {
        //�����Œx�������Ȃ��Ɠ����鏈���Ƃ��Ԃ��ăo�O��
        yield return new WaitForSeconds(0.5f);
        _inputObjectGet.PlayerState = PlayerState.Having; //�v���C���[�̃X�e�[�g��Having�ɂ���

    }
}
