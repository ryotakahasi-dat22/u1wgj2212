using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
                // transformを取得
                Transform myTransform = this.transform;

                // 座標を取得
                Vector3 pos = myTransform.position;
                pos.x = 10000.0f;    // y座標へ0.01加算

                myTransform.position = pos;  // 座標を設定
            //Time.timeScale = 0;
        }
    }

}
