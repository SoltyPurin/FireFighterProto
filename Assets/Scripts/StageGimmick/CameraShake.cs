using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float _duration = 0.5f;
    [SerializeField] private float _magnitude = 0.2f;
    public IEnumerator Shake()
    {
        Vector3 originalPosition = transform.position;
        float elapsed = 0f;
        float reduceMagnitude = _magnitude;

        while (elapsed < _duration)
        {
            transform.position = originalPosition + Random.insideUnitSphere *reduceMagnitude;
            if (reduceMagnitude >= 0)
            {
                reduceMagnitude -= 0.005f;
            }
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = originalPosition;
    }
}
