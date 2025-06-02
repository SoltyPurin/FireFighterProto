using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendObjectProtocol : MonoBehaviour
{
    [Header("他スクリプト取得")]
    //ボックスコライダーを分けるためにclosetObjectに情報を送る
    [SerializeField] private CatchProtocol _catchProtocol = default;
    [SerializeField] private ColorChangeClosetObjectProtocol _colorChangeProtocol = default;
    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage"))
        {
            _catchProtocol.ClosetObject = collision.gameObject;
            _colorChangeProtocol.ChangeColor(collision.gameObject);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage"))
        {
            _catchProtocol.ClosetObject = null;
            _colorChangeProtocol.ReturnColor(collision.gameObject);

        }

    }

}
