using UnityEngine;

public class DetectedObjectDirection : MonoBehaviour
{
    [SerializeField] private GameObject _breakDeblis = default; //��ꂽ���ɏo��j��
    [Header("�j�Ђ����o���H")]
    [SerializeField] private int _numberOfDeblis = 10; //�j�Ђ����o����
    private void OnCollisionEnter(Collision collision)
    {
        //Vector3 normal = collision.contacts[0].normal; 
        //Vector3 incoming = collision.rigidbody.velocity.normalized; //�����RigidBody�̑��x�x�N�g��
        //float angle = Vector3.Angle(incoming, normal);
        for(int i =0;i<=_numberOfDeblis; i++)
        {
            Instantiate(_breakDeblis, transform.position, Quaternion.identity);
            DeblisBlowAway blow = _breakDeblis.GetComponent<DeblisBlowAway>();
            //�ǂ���O�Ɍ������x�N�g��
            blow.BlowAway(collision.contacts[0].normal);
        }
        Destroy(this.gameObject);
    }
}
