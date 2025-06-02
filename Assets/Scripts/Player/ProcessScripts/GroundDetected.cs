using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetected : MonoBehaviour
{
    [Header("���X�N���v�g�擾")]
    [SerializeField] private InputJump _inputJump = default;

    private void OnTriggerEnter(Collider other)
    {
        _inputJump.IsDetectedGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _inputJump.IsDetectedGround = false;
    }
}
