using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjectAddForce : MonoBehaviour
{
    public void ObjectAddForce(Vector3 direction)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>(); //RigidBodyを取得
        rigidbody.AddForce(direction, ForceMode.Impulse); //directionで与えられた方向に吹き飛ばす
    }
}
