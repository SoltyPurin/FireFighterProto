using UnityEngine;

public class InputJump : MonoBehaviour
{
    [Header("���̃X�N���v�g�擾")]
    [SerializeField] private JumpProtocol _jumpProtocol = default;

    private readonly string JUMPBUTTONNAME = "Jump"; //�W�����v�̃{�^���̖��O������ϐ�
    private bool _isDetectedGround = true; //�n�ʂɂ��Ă邩�ǂ���
    public bool IsDetectedGround
    {
        set { _isDetectedGround = value; }  //GroundDetected�ŏ�������
    }
    private void Update()
    {
        //�W�����v�{�^���������ĂȂ����n�ʂɂ��鎞��true
        bool canJump = Input.GetButtonDown(JUMPBUTTONNAME) && _isDetectedGround;
        if (canJump)
        {
            //�W�����v�̃X�N���v�g�ɖ��߂��o��
            _jumpProtocol.JumpMethod();
        }
    }


}
