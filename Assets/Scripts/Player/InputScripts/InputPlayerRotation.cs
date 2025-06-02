using UnityEngine;

public class InputPlayerRotation : MonoBehaviour
{
    private float _slerpCorrectionValue = 5.0f; //Slerpの補完値

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
    }

    private void FixedUpdate()
    {
        //回転を代入
        _playerRotation = new Vector3(_horizontal, 0, _vertical).normalized;
        //プレイヤーの回転をLookAt地点に設定、それをQuaternionに反映
        Quaternion targetRotation = Quaternion.LookRotation(_playerRotation);
        //Slerpでなめらかに回転させる。なお、入力が無い時は自動的に元の角度に戻る
        transform.rotation = Quaternion.Slerp(this.transform.rotation,targetRotation, _slerpCorrectionValue);
    }
}
