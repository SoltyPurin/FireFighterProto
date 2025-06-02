using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    None,
    Having
}
public class InputGetObject : MonoBehaviour
{
    [Header("他スクリプト取得用")]
    [SerializeField] private CatchProtocol _catchTheObject = default;

    private readonly string CATCHBUTTONNAME = "Catch"; //取るボタンの変数名

    private PlayerState _playerState = PlayerState.None; //最初はなにも持ってないのでNoneを適用
    public PlayerState PlayerState
    {
        set { _playerState = value; } //CatchProtocolとThrowProtocolスクリプトから書き換え
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
            //キャッチの処理の実行命令を出す
            _catchTheObject.CatchMethod();
        }
    }
}
