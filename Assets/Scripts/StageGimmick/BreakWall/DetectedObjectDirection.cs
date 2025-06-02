using System.Collections;
using UnityEngine;

public class DetectedObjectDirection : MonoBehaviour
{
    [Header("�g���K�[�ɂ���p��BoxCollider")]
    [SerializeField] private BoxCollider _boxCollider = default;


    [SerializeField] private GameObject _breakDeblis = default; //��ꂽ���ɏo��j��
    [Header("�j�Ђ����o���H")]
    [SerializeField] private int _numberOfDeblis = 10; //�j�Ђ����o����
    private void OnCollisionEnter(Collision collision)
    {
        //�j�Ђ������Ȃ��悤�ɍŏ��͓����蔻�肾����Trigger�Ŗ���������
        _boxCollider.isTrigger = true;
        Debug.Log("�΂炯��");
        for (int i = 0; i <= _numberOfDeblis; i++)
        {
            GameObject debli = Instantiate(_breakDeblis, transform.position, Quaternion.identity);
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
