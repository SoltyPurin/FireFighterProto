using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputThrowObject : MonoBehaviour
{
    [Header("他スクリプト取得用")]
    [SerializeField] private ThrowProtocol _throwObject = default;
    [SerializeField] private InputGetObject _inputObjectGet = default;
    [SerializeField] private CatchProtocol _catchTheObject = default;

    private readonly string THROWBUTTONNAME = "Catch";　//catchボタンの名前を保存する変数、投げるのと拾うのは同じボタン

    private bool _canThrow = false; //投げられるかどうか。最初はなにも持ってないため投げられないのでfalse

    private void Update()
    {
        //Throwボタンが押されてなおかつプレイヤーのステートがHaving(オブジェクトを持っている)状態であれば投げられる
        _canThrow = Input.GetButtonDown(THROWBUTTONNAME) && _inputObjectGet.PlayerState == PlayerState.Having;

        if (_canThrow)
        {
            //投げる命令を出す
            _throwObject.ThrowMethod(_catchTheObject.HavingObject);
        }
    }
}
