using UnityEngine;

public class JumpProtocol : MonoBehaviour
{
    [Header("rigidBodyŽæ“¾")]
    [SerializeField] private Rigidbody _rigidBody = default;

    [SerializeField] private float _jumpPower = 5;
    public void JumpMethod()
    {
        _rigidBody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
    }
}
