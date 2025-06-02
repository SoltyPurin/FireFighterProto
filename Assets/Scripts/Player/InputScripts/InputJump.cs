using UnityEngine;

public class InputJump : MonoBehaviour
{
    [Header("他のスクリプト取得")]
    [SerializeField] private JumpProtocol _jumpProtocol = default;

    private readonly string JUMPBUTTONNAME = "Jump"; //ジャンプのボタンの名前を入れる変数
    private bool _isDetectedGround = true; //地面についてるかどうか
    public bool IsDetectedGround
    {
        set { _isDetectedGround = value; }  //GroundDetectedで書き換え
    }
    private void Update()
    {
        //ジャンプボタンを押してなおかつ地面にいる時にtrue
        bool canJump = Input.GetButtonDown(JUMPBUTTONNAME) && _isDetectedGround;
        if (canJump)
        {
            //ジャンプのスクリプトに命令を出す
            _jumpProtocol.JumpMethod();
        }
    }


}
