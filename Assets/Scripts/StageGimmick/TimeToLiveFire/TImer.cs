using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _fireUpTimer = default; //‰Š‚ª”­¶‚µ‚Ä‚©‚ç‚ÌŽžŠÔ‚ð•Û‘¶
    private bool _isMediumFireUpCallOnce = false; //’†‚­‚ç‚¢‚Ì‰Š‚Í”­¶‚µ‚½‚©
    private bool _isLergeFireUpCallOnce = false; //‘å‚«‚È‰Š‚Í”­¶‚µ‚½‚©
    private float _mediumFireUpTime = default; //’†‚­‚ç‚¢‚Ì‰Š‚ª”­¶‚·‚é‚Ü‚Å‚ÌŽžŠÔ
    private const float LOWERVALUEMEDIUMFIRETIME = 30; //Å‘¬‚Å’†‚­‚ç‚¢‚Ì‰Š‚É”­“W
    private const float HIGHERVALUERMEDIUMFIRETIME = 75;//Å’x‚Å’†‚­‚ç‚¢‚Ì‰Š‚É”­“W
    private float _lergeFireUpTime = default; //‘å‚«‚È‰Š‚ª”­¶‚·‚é‚Ü‚Å‚ÌŽžŠÔ
    private const float LOWERLERGEFIRETIME = 100; //Å‘¬‚Å‘å‚«‚È‰Š‚É”­“W‚·‚éŽžŠÔ
    private const float HIGHERLERGEFIRETIME = 150;//Å’x‚Å‘å‚«‚È‰Š‚É”­“W‚·‚éŽžŠÔ
    //’iŠK“I‚É‰Î‚ð‹­‚ß‚éA¬‚Í•’Ê‚É“n‚ê‚éB’†‚ÍƒWƒƒƒ“ƒv‚µ‚Ä’Ê‚ê‚éB‘å‚Í’Ê‚ê‚È‚¢

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
