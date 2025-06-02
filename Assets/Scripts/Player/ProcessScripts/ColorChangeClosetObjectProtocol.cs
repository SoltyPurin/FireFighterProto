using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeClosetObjectProtocol : MonoBehaviour
{
    //���Ă�I�u�W�F�N�g�̐F��ς���B�ŏI�I�ɂ͎��Ă�I�u�W�F�N�g�̎���ɋ��F�̗֊s��\��������
    public void ChangeColor(GameObject closetObject)
    {
        //���Ă�I�u�W�F�N�g�̐F��ς���
        closetObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void ReturnColor(GameObject closetObject)
    {
        //���Ă�I�u�W�F�N�g����Ȃ��Ȃ�����F��߂�
        closetObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
