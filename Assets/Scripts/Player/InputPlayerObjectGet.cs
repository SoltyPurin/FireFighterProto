using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayerObjectGet : MonoBehaviour
{
    [Header("他スクリプト取得用")]
    [SerializeField] private CatchTheObject _catchTheObject = default;

    private readonly string CATCHBUTTONNAME = "Catch"; //取るボタンの変数名

    private bool _isHaveingObject = false; //オブジェクトを持ってるかどうか
    private void Update()
    {
        bool canCatch = Input.GetButtonDown(CATCHBUTTONNAME) && _isHaveingObject;
        if (canCatch)
        {
            _catchTheObject.CatchProtocol();
        }
    }
}
