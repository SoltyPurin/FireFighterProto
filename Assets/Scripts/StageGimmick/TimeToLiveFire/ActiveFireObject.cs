using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveFireObject : MonoBehaviour
{
    [SerializeField] private Vector3 _mediumFireSize = new Vector3(1, 0.5f,1);
    [SerializeField] private Vector3 _lergeFireSize = new Vector3(1, 10, 1);

    public void MediumFireUp()
    {
        transform.localScale = _mediumFireSize;
    }

    public void LergeFireUp()
    {
        transform.localScale = _lergeFireSize;
    }
}
