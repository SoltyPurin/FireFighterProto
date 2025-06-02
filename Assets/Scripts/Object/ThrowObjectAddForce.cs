using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjectAddForce : MonoBehaviour
{
    public void ObjectAddForce(Vector3 direction)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Debug.Log(direction);
        rigidbody.AddForce(direction, ForceMode.Impulse);
    }
}
