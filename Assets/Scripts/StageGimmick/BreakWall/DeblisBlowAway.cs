using System.Collections;
using UnityEngine;

public class DeblisBlowAway : MonoBehaviour
{
    [Header("リジッドボディ取得")]
    [SerializeField] private Rigidbody _rigidBody = default;

    [SerializeField] private float _forceOfDirection = 10; //吹っ飛びに乗算する力
    public void BlowAway(Vector3 direction)
    {
        //吹っ飛びを乗算
        direction *= _forceOfDirection;
        //吹っ飛ばす
        _rigidBody.AddForce(direction, ForceMode.VelocityChange);
        //コルーチン起動
        StartCoroutine(DestroyDebli());
    }

    private IEnumerator DestroyDebli()
    {
        //少しだけ遅らせて破片を削除する
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
