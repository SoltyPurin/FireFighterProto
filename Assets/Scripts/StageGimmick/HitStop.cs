using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStop : MonoBehaviour
{
    [Header("���Ԃ̃X�P�[��")]
    [SerializeField]private float _hitStopTimeScale = 0.6f;
    [Header("�ǂꂭ�炢�̎��ԃX���[�ɂ��邩")]
    [SerializeField]private float _waitForSeconds = 0.8f;

    [Header("�J������h�炷�X�N���v�g")]
    [SerializeField] private CameraShake _cameraShake = default;

    //�q�b�g�X�g�b�v�̓^�C���X�P�[�������ł͍Č��ł��Ȃ��B
    //�ǉ󂷃^�C�~���O���ǂꂭ�炢���邩�Ƃ����̂��厖
    //�q�b�g�X�g�b�v������̂́A������Ԃ̏��
    //�g���ǂ�����厖
    public void HitStopMethod()
    {
        Time.timeScale = _hitStopTimeScale;
        StartCoroutine(ReturnTimeScale());
        _cameraShake.StartCoroutine("Shake");
    }
    private IEnumerator ReturnTimeScale()
    {
        yield return new WaitForSeconds(_waitForSeconds);
        Time.timeScale = 1;
    }
}
