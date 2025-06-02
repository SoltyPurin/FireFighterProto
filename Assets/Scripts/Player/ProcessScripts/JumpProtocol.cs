using UnityEngine;

public class JumpProtocol : MonoBehaviour
{
    [Header("rigidBody�擾")]
    [SerializeField] private Rigidbody _rigidBody = default;

    [SerializeField] private float _jumpPower = 5; //�W�����v��
    public void JumpMethod()
    {
        //�W�����v�����A���AddForce
        _rigidBody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
    }
}
