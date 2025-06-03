using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _fireUpTimer = default; //�����������Ă���̎��Ԃ�ۑ�
    private bool _isMediumFireUpCallOnce = false; //�����炢�̉��͔���������
    private bool _isLergeFireUpCallOnce = false; //�傫�ȉ��͔���������
    private float _mediumFireUpTime = default; //�����炢�̉�����������܂ł̎���
    private const float LOWERVALUEMEDIUMFIRETIME = 30; //�ő��Œ����炢�̉��ɔ��W
    private const float HIGHERVALUERMEDIUMFIRETIME = 75;//�Œx�Œ����炢�̉��ɔ��W
    private float _lergeFireUpTime = default; //�傫�ȉ�����������܂ł̎���
    private const float LOWERLERGEFIRETIME = 100; //�ő��ő傫�ȉ��ɔ��W���鎞��
    private const float HIGHERLERGEFIRETIME = 150;//�Œx�ő傫�ȉ��ɔ��W���鎞��
    //�i�K�I�ɉ΂����߂�A���͕��ʂɓn���B���̓W�����v���Ēʂ��B��͒ʂ�Ȃ�

    private void Start()
    {
        _mediumFireUpTime = Random.Range(LOWERVALUEMEDIUMFIRETIME,HIGHERVALUERMEDIUMFIRETIME);
        _lergeFireUpTime = Random.Range(LOWERLERGEFIRETIME, HIGHERLERGEFIRETIME);
    }
    private void Update()
    {
        _fireUpTimer += Time.deltaTime;
        if (_fireUpTimer >= _mediumFireUpTime)
        {

        }
    }
}
