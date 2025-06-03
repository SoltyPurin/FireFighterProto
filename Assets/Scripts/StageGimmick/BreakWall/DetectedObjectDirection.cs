using System.Collections;
using UnityEngine;

public class DetectedObjectDirection : MonoBehaviour
{
    [Header("�g���K�[�ɂ���p��BoxCollider")]
    [SerializeField] private BoxCollider _boxCollider = default;
    [Header("���X�N���v�g�擾")]
    [SerializeField] private GameObject _breakDeblis = default; //��ꂽ���ɏo��j��
    [Header("�j�Ђ����o���H")]
    [SerializeField] private int _numberOfDeblis = 10; //�j�Ђ����o����

    private readonly string HITSTOPTAGNAME = "HitStop";
    private void OnCollisionEnter(Collision collision)
    {
        if(!(collision.rigidbody.velocity.magnitude >= 0.5f)) //���x���Ȃ��Ɖ��Ȃ��悤�ɂ���
        {
            return;
        }
        //�q�b�g�X�g�b�v�̃X�N���v�g�������Ă�I�u�W�F�N�g������
        GameObject hitStopObject = GameObject.FindWithTag(HITSTOPTAGNAME);
        //�q�b�g�X�g�b�v�̃X�N���v�g���擾
        HitStop hitStop = hitStopObject.GetComponent<HitStop>();
        //�q�b�g�X�g�b�v���o���Ăяo��
        hitStop.HitStopMethod();
        //�j�Ђ������Ȃ��悤�ɍŏ��͓����蔻�肾����Trigger�Ŗ���������
        _boxCollider.isTrigger = true;
        for (int i = 0; i <= _numberOfDeblis; i++)
        {
            //�j�Ђ𐶐�����debli�Ɏ��e
            GameObject debli = Instantiate(_breakDeblis, transform.position, Quaternion.identity); 
            //���������j�Ђ���X�N���v�g���擾
            DeblisBlowAway blow = debli.GetComponent<DeblisBlowAway>();
            //�ǂ���O�Ɍ������x�N�g��,randomOffset�Ń����_���Ȓl����
            Vector3 randomOffset = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            //�I�u�W�F�N�g�̓��ˊp�Ƌt�̕����Ƀ����_���ȃo���������悹��������ۑ�
            Vector3 blowDirection = (collision.contacts[0].normal + randomOffset).normalized;
            //������΂�
            blow.BlowAway(blowDirection);
        }
        //�ǂ�j��
        Destroy(this.gameObject);
    }

}
