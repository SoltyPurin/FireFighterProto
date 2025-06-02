using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjectAddForce : MonoBehaviour
{
    public void ObjectAddForce(Vector3 direction)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>(); //RigidBody‚ğæ“¾
        rigidbody.AddForce(direction, ForceMode.Impulse); //direction‚Å—^‚¦‚ç‚ê‚½•ûŒü‚É‚«”ò‚Î‚·
    }
}
