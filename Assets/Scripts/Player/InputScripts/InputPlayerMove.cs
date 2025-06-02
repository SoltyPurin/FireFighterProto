using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayerMove : MonoBehaviour
{
    [Header("取得用の変数")]
    [SerializeField] private Rigidbody _rigidBody = default; //移動用のrigidbody取得
    [Header("速度調整")]
    [SerializeField] private float _moveSpeedMultiplier = 0.5f; //速度を調整する用の数字

    private readonly string HORIZONTALNAME = "Horizontal";   //水平の名前変数
    private readonly string VERTICALNAME = "Vertical";       //垂直の名前変数

    private float _horizontal = default;                     //水平の入力値の入れ物
    private float _vertical = default;                       //垂直の入力値の入れ物
    private void Update()
    {
        //水平の入力値を代入。そして早すぎるので減速
        _horizontal = Input.GetAxis(HORIZONTALNAME) * _moveSpeedMultiplier;
        //垂直の入力値を代入。そして早すぎるので減速
        _vertical = Input.GetAxis(VERTICALNAME) * _moveSpeedMultiplier;             
    }

    private void FixedUpdate()
    {
        _rigidBody.position += new Vector3(_horizontal, 0, _vertical); //移動処理
    }
}
