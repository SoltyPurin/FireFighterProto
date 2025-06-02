using UnityEngine;

public class InputJump : MonoBehaviour
{
    [Header("他のスクリプト取得")]
    [SerializeField] private JumpProtocol _jumpProtocol = default;

    private readonly string JUMPBUTTONNAME = "Jump";
    private bool _isDetectedGround = true;
    public bool IsDetectedGround
    {
        set { _isDetectedGround = value; } 
    }
    private void Update()
    {
        bool canJump = Input.GetButtonDown(JUMPBUTTONNAME) && _isDetectedGround;
        if (canJump)
        {
            _jumpProtocol.JumpMethod();
        }
    }


}
