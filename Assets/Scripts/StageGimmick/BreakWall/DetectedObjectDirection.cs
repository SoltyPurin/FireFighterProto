using System.Collections;
using UnityEngine;

public class DetectedObjectDirection : MonoBehaviour
{
    [Header("トリガーにする用のBoxCollider")]
    [SerializeField] private BoxCollider _boxCollider = default;
    [Header("他スクリプト取得")]
    [SerializeField] private GameObject _breakDeblis = default; //壊れた時に出る破片
    [Header("破片を何個出す？")]
    [SerializeField] private int _numberOfDeblis = 10; //破片を何個出すか

    private readonly string HITSTOPTAGNAME = "HitStop";
    private void OnCollisionEnter(Collision collision)
    {
        if(!(collision.rigidbody.velocity.magnitude >= 0.5f)) //速度がないと壊れないようにする
        {
            return;
        }
        //ヒットストップのスクリプトを持ってるオブジェクトを検索
        GameObject hitStopObject = GameObject.FindWithTag(HITSTOPTAGNAME);
        //ヒットストップのスクリプトを取得
        HitStop hitStop = hitStopObject.GetComponent<HitStop>();
        //ヒットストップ演出を呼び出す
        hitStop.HitStopMethod();
        //破片が干渉しないように最初は当たり判定だけをTriggerで無効化する
        _boxCollider.isTrigger = true;
        for (int i = 0; i <= _numberOfDeblis; i++)
        {
            //破片を生成しつつdebliに収容
            GameObject debli = Instantiate(_breakDeblis, transform.position, Quaternion.identity); 
            //生成した破片からスクリプトを取得
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
