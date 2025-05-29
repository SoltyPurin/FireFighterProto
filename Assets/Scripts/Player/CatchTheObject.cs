using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchTheObject : MonoBehaviour
{
    [Header("Žæ“¾—p")]
    [SerializeField] private BoxCollider _boxCollider = default;

    private bool _canCatch = false;

    [SerializeField] private GameObject _closestObject = default;

    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Stage"))
        {
            _closestObject = collision.gameObject;
        }
    }

    public void CatchProtocol()
    {
        _closestObject.transform.SetParent(this.transform);
    }
}
