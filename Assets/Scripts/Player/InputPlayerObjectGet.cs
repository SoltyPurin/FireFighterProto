using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    None,
    Having
}
public class InputPlayerObjectGet : MonoBehaviour
{
    [Header("他スクリプト取得用")]
    [SerializeField] private CatchTheObject _catchTheObject = default;

    private readonly string CATCHBUTTONNAME = "Catch"; //取るボタンの変数名

    private PlayerState _playerState = PlayerState.None;
    public PlayerState PlayerState
    {
        set { _playerState = value; } //CatchTheObjectスクリプトから書き換え
        get { return _playerState; } //InputPlayerObjectThrowから参照
    }

    //オブジェクトを取れるかどうか
    private bool _canCatch = false;
    private void Update()
    {
        //ボタンを押したときに近くにオブジェクトがあって、投げるboolがfalseの時にtrue
        _canCatch = Input.GetButtonDown(CATCHBUTTONNAME) && _playerState == PlayerState.None;

        if (_canCatch)
        {
            Debug.Log("キャッチ");
            _catchTheObject.CatchProtocol();
        }
    }
}
