using System.Collections;
using UnityEngine;

public class DeblisBlowAway : MonoBehaviour
{
    [Header("���W�b�h�{�f�B�擾")]
    [SerializeField] private Rigidbody _rigidBody = default;

    [SerializeField] private float _forceOfDirection = 10; //������тɏ�Z�����
    public void BlowAway(Vector3 direction)
    {
        //������т���Z
        direction *= _forceOfDirection;
        //������΂�
        _rigidBody.AddForce(direction, ForceMode.VelocityChange);
        //�R���[�`���N��
        StartCoroutine(DestroyDebli());
    }

    private IEnumerator DestroyDebli()
    {
        //���������x�点�Ĕj�Ђ��폜����
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
