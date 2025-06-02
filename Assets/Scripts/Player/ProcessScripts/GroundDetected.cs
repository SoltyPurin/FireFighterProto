using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetected : MonoBehaviour
{
    [Header("他スクリプト取得")]
    [SerializeField] private InputJump _inputJump = default;

    private void OnTriggerEnter(Collider other)
    {
        //地面についてたらIsDetectedGroundをtrueにする
        _inputJump.IsDetectedGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //地面から離れたらIsDetectedGroundをfalseにする
        _inputJump.IsDetectedGround = false;
    }
}
