using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendObjectProtocol : MonoBehaviour
{
    [Header("他スクリプト取得")]
    //ボックスコライダーを分けるためにclosetObjectに情報を送る
    [SerializeField] private CatchProtocol _catchProtocol = default;
    [SerializeField] private ColorChangeClosetObjectProtocol _colorChangeProtocol = default; //箱色替え界隈のスクリプト
    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage")) //ステージのタグがついてる物以外だったら持てるようにする
        {
            _catchProtocol.ClosetObject = collision.gameObject; //一番近いオブジェクトをClosetオブジェクトに代入する
            _colorChangeProtocol.ChangeColor(collision.gameObject); //箱色替え界隈
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage")) //ステージのタグがついてる物以外だった場合処理を続行
        {
            _catchProtocol.ClosetObject = null; //ClosetObjectの中身を解除
            _colorChangeProtocol.ReturnColor(collision.gameObject);//色戻し界隈

        }

    }

}
