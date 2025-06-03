using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStop : MonoBehaviour
{
    private float _hitStopTimeScale = 0.6f;
    private float _waitForSeconds = 0.8f;
    public void HitStopMethod()
    {
        Time.timeScale = _hitStopTimeScale;
        StartCoroutine(ReturnTimeScale());
    }
    private IEnumerator ReturnTimeScale()
    {
        yield return new WaitForSeconds(_waitForSeconds);
        Time.timeScale = 1;
    }
}
