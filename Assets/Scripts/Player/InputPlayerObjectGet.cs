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
    [SerializeField] private ThrowObject _throwObject = default;

    private readonly string CATCHBUTTONNAME = "Catch"; //取るボタンの変数名

    private PlayerState _playerState = PlayerState.None;
    public PlayerState PlayerState
    {
        set { _playerState = value; }
    }
    //オブジェクトを持ってるかどうか
    private bool _isHavingObject = false;

    //オブジェクトを取れるかどうか
    private bool _canCatch = false;
    //オブジェクトを投げられるかどうか
    private bool _canThrow = false;
    private void Update()
    {
        //オブジェクトを持ったらtrueになる
        _isHavingObject = _catchTheObject.HavingObject != null;
        //ボタンを押したときに近くにオブジェクトがあって、投げるboolがfalseの時にtrue
        _canCatch = Input.GetButtonDown(CATCHBUTTONNAME) && _playerState == PlayerState.None;
        //ボタンを押したときにオブジェクトを持ってたらtrue
        _canThrow = Input.GetButtonDown(CATCHBUTTONNAME) && _playerState == PlayerState.Having;

        if (_canCatch)
        {
            Debug.Log("キャッチ");
            _catchTheObject.CatchProtocol();
        }else if (_canThrow)
        {
            Debug.Log("リリース");
            _throwObject.ObjectThrow(_catchTheObject.ClosetObject);
        }
    }
}
