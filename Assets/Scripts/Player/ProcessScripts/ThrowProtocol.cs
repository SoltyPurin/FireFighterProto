using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowProtocol : MonoBehaviour
{
    [Header("���X�N���v�g�擾�p")]
    [SerializeField] private CatchProtocol _catchTheObject = default;
    [SerializeField] private InputGetObject _inputPlayerObjectGet = default;

    public void ThrowMethod(GameObject closetObject)
    {
        if (closetObject == null)�@//�߂��ɕ����Ȃ��ꍇ��return
        {
            return;
        }
        closetObject.transform.SetParent(null); //�e�q�֌W������
        ThrowObjectAddForce throwObjectAddForce = closetObject.GetComponent<ThrowObjectAddForce>();//�X�N���v�g���擾
        Rigidbody closetObjectRigidBody = closetObject.GetComponent<Rigidbody>();//rigidbody���擾
        BoxCollider closetObjectBoxCollider = closetObject.GetComponent<BoxCollider>();//boxcollider���擾
        closetObjectRigidBody.isKinematic = false;//isKinematic��false�ɂ��ĕ������Z���ĊJ����
        closetObjectBoxCollider.enabled = true;//boxCollider��L��������
        throwObjectAddForce.ObjectAddForce(transform.forward);//���𓊂���X�N���v�g�����s�A���ʂ̕����������Ƃ��ēn��
        StartCoroutine(ChangeState());
    }

    private IEnumerator ChangeState()
    {
        //�����ŏ����ҋ@�����Ȃ��Ƌ߂��ɃI�u�W�F�N�g�������2�������Ă��܂�
        yield return new WaitForSeconds(0.5f);
        _inputPlayerObjectGet.PlayerState = PlayerState.None;
    }
}
