using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeClosetObjectProtocol : MonoBehaviour
{
    //持てるオブジェクトの色を変える。最終的には持てるオブジェクトの周りに金色の輪郭を表示させる
    public void ChangeColor(GameObject closetObject)
    {
        //持てるオブジェクトの色を変える
        closetObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void ReturnColor(GameObject closetObject)
    {
        //持てるオブジェクトじゃなくなったら色を戻す
        closetObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
