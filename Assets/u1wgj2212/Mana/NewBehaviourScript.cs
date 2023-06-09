using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {

        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;
        pos.y += 0.048f;    // y座標へ0.01加算

        if (GameManager.score >= 100000)
        {
            pos.y += 0.012f;
        }
        if (GameManager.score >= 1000000)
        {
            pos.y += 0.024f;
        }
        if (GameManager.score >= 5000000)
        {
            pos.y += 0.036f;
        }
        if (GameManager.score >= 10000000)
        {
            pos.y += 0.006f;
        }

        myTransform.position = pos;  // 座標を設定
    }
}