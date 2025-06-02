using UnityEngine;

public class DetectedObjectDirection : MonoBehaviour
{
    [SerializeField] private GameObject _breakDeblis = default; //壊れた時に出る破片
    [Header("破片を何個出す？")]
    [SerializeField] private int _numberOfDeblis = 10; //破片を何個出すか
    private void OnCollisionEnter(Collision collision)
    {
        //Vector3 normal = collision.contacts[0].normal; 
        //Vector3 incoming = collision.rigidbody.velocity.normalized; //相手のRigidBodyの速度ベクトル
        //float angle = Vector3.Angle(incoming, normal);
        for(int i =0;i<=_numberOfDeblis; i++)
        {
            Instantiate(_breakDeblis, transform.position, Quaternion.identity);
            DeblisBlowAway blow = _breakDeblis.GetComponent<DeblisBlowAway>();
            //壁から外に向かうベクトル
            blow.BlowAway(collision.contacts[0].normal);
        }
        Destroy(this.gameObject);
    }
}
