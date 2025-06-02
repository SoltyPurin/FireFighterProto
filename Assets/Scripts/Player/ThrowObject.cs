using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [Header("他スクリプト取得用")]
    [SerializeField] private CatchTheObject _catchTheObject = default;
    [SerializeField] private InputPlayerObjectGet _inputPlayerObjectGet = default;

    public void ObjectThrow(GameObject closetObject)
    {
        if (closetObject == null)
        {
            return;
        }
        closetObject.transform.SetParent(null);
        ThrowObjectAddForce throwObjectAddForce = closetObject.GetComponent<ThrowObjectAddForce>();
        Rigidbody closetObjectRigidBody = closetObject.GetComponent<Rigidbody>();
        BoxCollider closetObjectBoxCollider = closetObject.GetComponent<BoxCollider>();
        closetObjectRigidBody.isKinematic = false;
        closetObjectBoxCollider.enabled = true;
        throwObjectAddForce.ObjectAddForce(transform.forward);
        Invoke("ChangeState", 0.5f);
    }

    private void ChangeState()
    {
        _inputPlayerObjectGet.PlayerState = PlayerState.None;
    }
}
