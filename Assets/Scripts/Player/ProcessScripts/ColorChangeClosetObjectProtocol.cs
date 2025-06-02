using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeClosetObjectProtocol : MonoBehaviour
{
    public void ChangeColor(GameObject closetObject)
    {
        closetObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void ReturnColor(GameObject closetObject)
    {
        closetObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
