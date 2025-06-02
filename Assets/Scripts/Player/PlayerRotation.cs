using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{


    private Vector3 _playerRotation = default; //回転方向の入れ物

    private readonly string HORIZONTALNAME = "Horizontal";   //水平の名前変数
    private readonly string VERTICALNAME = "Vertical";       //垂直の名前変数

    private float _horizontal = default;                     //水平の入力値の入れ物
    private float _vertical = default;                       //垂直の入力値の入れ物

    private void Update()
    {
        //水平の入力値を代入
        _horizontal = Input.GetAxis(HORIZONTALNAME);
        //垂直の入力値を代入
        _vertical = Input.GetAxis(VERTICALNAME) ;
        _playerRotation = new Vector3(_horizontal, 0, _vertical).normalized;
    }

    private void FixedUpdate()
    {
        Quaternion targetRotation = Quaternion.LookRotation(_playerRotation);
        transform.rotation = Quaternion.Slerp(this.transform.rotation,targetRotation,5);
    }
}
