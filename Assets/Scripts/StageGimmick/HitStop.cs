using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStop : MonoBehaviour
{
    [Header("時間のスケール")]
    [SerializeField]private float _hitStopTimeScale = 0.6f;
    [Header("どれくらいの時間スローにするか")]
    [SerializeField]private float _waitForSeconds = 0.8f;

    [Header("カメラを揺らすスクリプト")]
    [SerializeField] private CameraShake _cameraShake = default;

    [Header("コントローラーのバイブレーション")]
    [SerializeField] private ViblationOfController _viblation = default;

    //ヒットストップはタイムスケールだけでは再現できない。
    //壁壊すタイミングがどれくらいあるかというのも大事
    //ヒットストップが光るのは、ここ一番の場面
    //使いどころも大事
    public void HitStopMethod()
    {
        Time.timeScale = _hitStopTimeScale;
        StartCoroutine(ReturnTimeScale());
        _cameraShake.StartCoroutine("Shake");
        _viblation.WaitForSeconds = _waitForSeconds;
        _viblation.StartCoroutine("BreakWallViblation");
    }
    private IEnumerator ReturnTimeScale()
    {
        yield return new WaitForSeconds(_waitForSeconds);
        Time.timeScale = 1;
    }
}
