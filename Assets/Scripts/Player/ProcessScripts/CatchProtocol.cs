using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchProtocol : MonoBehaviour
{
    [Header("取得用")]
    [SerializeField] private InputGetObject _inputObjectGet = default;

    [Header("近くにあるオブジェクトの情報が入るのでインスペクターでは入れない")]
    [SerializeField] private GameObject _closetObject = default; //近くにあるオブジェクト

    public GameObject ClosetObject
    {
        set { _closetObject = value; } //SendObjectProtocolによりsetし、情報を受け取る
    }
    [SerializeField] private GameObject _havingObject = default;//取得したオブジェクト

    public GameObject HavingObject
    {
        get { return _havingObject; } //持っているオブジェクトを他スクリプトから参照できるようにする
    }


    public void CatchMethod()
    {
        if(_closetObject == null)
        {
            return; //近くに物がない場合はreturn
        }
        _havingObject = _closetObject; //近くにある(closet)オブジェクトから持ってる(Having)オブジェクトにする
        _closetObject = null; //近くにあるオブジェクトはnullにする
        StartCoroutine(ChangeState()); //ここでステート変更の処理を走らせる
        _havingObject.transform.SetParent(this.transform); //プレイヤーの子オブジェクトにする
        Vector3 initClosetObjectPosition = _havingObject.transform.position; //そのオブジェクトの座標を取得
        initClosetObjectPosition.y += 0.5f; //少し持ち上げる、これをしないと気持ちよく投げられない
        _havingObject.transform.position = initClosetObjectPosition; //持ち上げた後の座標を反映
        Rigidbody havingObjectRigidBody = _havingObject.GetComponent<Rigidbody>(); //オブジェクトのrigidbodyを取得
        BoxCollider havingObjectBoxCollider = _havingObject.GetComponent<BoxCollider>(); //boxColliderも取得
        havingObjectBoxCollider.enabled = false; //boxColliderを無効化し、ひっかからなくする
        havingObjectRigidBody.isKinematic = true;//isKinematicをtrueにし、物理挙動を無効化する
    }

    private IEnumerator ChangeState()
    {
        //ここで遅延させないと投げる処理とかぶってバグる
        yield return new WaitForSeconds(0.5f);
        _inputObjectGet.PlayerState = PlayerState.Having; //プレイヤーのステートをHavingにする

    }
}
