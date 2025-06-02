using System.Collections;
using UnityEngine;

public class DetectedObjectDirection : MonoBehaviour
{
    [Header("トリガーにする用のBoxCollider")]
    [SerializeField] private BoxCollider _boxCollider = default;


    [SerializeField] private GameObject _breakDeblis = default; //壊れた時に出る破片
    [Header("破片を何個出す？")]
    [SerializeField] private int _numberOfDeblis = 10; //破片を何個出すか
    private void OnCollisionEnter(Collision collision)
    {
        //破片が干渉しないように最初は当たり判定だけをTriggerで無効化する
        _boxCollider.isTrigger = true;
        Debug.Log("ばらける");
        for (int i = 0; i <= _numberOfDeblis; i++)
        {
            GameObject debli = Instantiate(_breakDeblis, transform.position, Quaternion.identity);
            DeblisBlowAway blow = debli.GetComponent<DeblisBlowAway>();
            //壁から外に向かうベクトル,randomOffsetでランダムな値を代入
            Vector3 randomOffset = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            //オブジェクトの入射角と逆の方向にランダムなバラけ方を乗せた方向を保存
            Vector3 blowDirection = (collision.contacts[0].normal + randomOffset).normalized;
            //吹き飛ばす
            blow.BlowAway(blowDirection);
        }
        //壁を破壊
        Destroy(this.gameObject);
    }

}
