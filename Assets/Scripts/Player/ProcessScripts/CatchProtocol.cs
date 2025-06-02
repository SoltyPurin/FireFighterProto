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
        set { _closetObject = value; }
    }
    [SerializeField] private GameObject _havingObject = default;//取得したオブジェクト

    public GameObject HavingObject
    {
        get { return _havingObject; }
    }


    public void CatchMethod()
    {
        if(_closetObject == null)
        {
            return;
        }
        _havingObject = _closetObject;
        _closetObject = null;
        Invoke("ChangeState", 0.5f);
        _havingObject.transform.SetParent(this.transform);
        Vector3 initClosetObjectPosition = _havingObject.transform.position;
        initClosetObjectPosition.y += 0.5f;
        _havingObject.transform.position = initClosetObjectPosition;
        Rigidbody havingObjectRigidBody = _havingObject.GetComponent<Rigidbody>();
        BoxCollider havingObjectBoxCollider = _havingObject.GetComponent<BoxCollider>();
        havingObjectBoxCollider.enabled = false;
        havingObjectRigidBody.isKinematic = true;
    }

    private void ChangeState()
    {
        _inputObjectGet.PlayerState = PlayerState.Having;

    }
}
