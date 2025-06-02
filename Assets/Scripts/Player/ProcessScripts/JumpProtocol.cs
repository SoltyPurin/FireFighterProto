using UnityEngine;

public class JumpProtocol : MonoBehaviour
{
    [Header("rigidBody取得")]
    [SerializeField] private Rigidbody _rigidBody = default;

    [SerializeField] private float _jumpPower = 5; //ジャンプ力
    public void JumpMethod()
    {
        //ジャンプ処理、上にAddForce
        _rigidBody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
    }
}
