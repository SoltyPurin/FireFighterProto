using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [Header("他スクリプト取得用")]
    [SerializeField] private CatchTheObject _catchTheObject = default;

    public void ObjectThrow(GameObject closetObject)
    {
        if (closetObject == null)
        {
            return;
        }
        closetObject.transform.SetParent(null);
        Rigidbody closetObjectRigidBody = closetObject.GetComponent<Rigidbody>();
        closetObjectRigidBody.isKinematic = false;
        closetObjectRigidBody.AddForce(Vector3.forward, ForceMode.VelocityChange);
    }
}
