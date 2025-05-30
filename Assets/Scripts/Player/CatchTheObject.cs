using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchTheObject : MonoBehaviour
{
    [Header("取得用")]
    [SerializeField] private BoxCollider _boxCollider = default;
    [SerializeField] private InputPlayerObjectGet _inputObjectGet = default;

    private bool _canCatch = false;

    [SerializeField] private GameObject _closetObject = default; //近くにあるオブジェクト

    public GameObject ClosetObject
    {
        get { return _closetObject; }
    }
    [SerializeField] private GameObject _havingObject = default;//取得したオブジェクト

    public GameObject HavingObject
    {
        get { return _havingObject; }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage"))
        {
            _closetObject = collision.gameObject;
        }
    }

    public void CatchProtocol()
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
        Rigidbody _closetObjectRigidBody = _havingObject.GetComponent<Rigidbody>();
        _closetObjectRigidBody.isKinematic = true;
    }

    private void ChangeState()
    {
        _inputObjectGet.PlayerState = PlayerState.Having;

    }
}
