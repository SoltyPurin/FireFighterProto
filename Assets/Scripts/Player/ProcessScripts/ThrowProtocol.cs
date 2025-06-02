using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowProtocol : MonoBehaviour
{
    [Header("他スクリプト取得用")]
    [SerializeField] private CatchProtocol _catchTheObject = default;
    [SerializeField] private InputGetObject _inputPlayerObjectGet = default;

    public void ThrowMethod(GameObject closetObject)
    {
        if (closetObject == null)　//近くに物がない場合はreturn
        {
            return;
        }
        closetObject.transform.SetParent(null); //親子関係を解消
        ThrowObjectAddForce throwObjectAddForce = closetObject.GetComponent<ThrowObjectAddForce>();//スクリプトを取得
        Rigidbody closetObjectRigidBody = closetObject.GetComponent<Rigidbody>();//rigidbodyを取得
        BoxCollider closetObjectBoxCollider = closetObject.GetComponent<BoxCollider>();//boxcolliderを取得
        closetObjectRigidBody.isKinematic = false;//isKinematicをfalseにして物理演算を再開する
        closetObjectBoxCollider.enabled = true;//boxColliderを有効化する
        throwObjectAddForce.ObjectAddForce(transform.forward);//物を投げるスクリプトを実行、正面の方向を引数として渡す
        StartCoroutine(ChangeState());
    }

    private IEnumerator ChangeState()
    {
        //ここで少し待機させないと近くにオブジェクトがあると2個持ちしてしまう
        yield return new WaitForSeconds(0.5f);
        _inputPlayerObjectGet.PlayerState = PlayerState.None;
    }
}
