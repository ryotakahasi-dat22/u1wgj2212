using UnityEngine;
using UnityEngine.EventSystems;

public class boorukenti : MonoBehaviour, IPointerClickHandler
{
    int tama=0;
    void Update()
    {

        // transformを取得
        Transform myTransform = this.transform;

        //座標を取得
        Vector3 pos = myTransform.position;
        pos.y += 0.036f;    // y座標へ0.01加算
        if(tama>=2)
        {
            pos.y -= 0.024f;
        }
        myTransform.position = pos;  // 座標を設定
    }

// クリックされたときに呼び出されるメソッド
public void OnPointerClick(PointerEventData eventData)
    {
        TinyAudio.PlaySE(TinyAudio.SE.Click);
        tama += 1;
            Transform myTransform = this.transform;
            //print($"オブジェクト {name} がクリックされたよ！");
            Vector3 pos = myTransform.position;
            //pos.x += 0.01f;    // x座標へ0.01加算
            pos.y += 2.00f;    // y座標へ0.01加算
                               //pos.z += 0.01f;    // z座標へ0.01加算
            myTransform.position = pos;
    }
}

