using UnityEngine;
using UnityEngine.EventSystems;

public class boorukenti : MonoBehaviour, IPointerClickHandler
{
    int tama=0;
    void Update()
    {

        // transform���擾
        Transform myTransform = this.transform;

        //���W���擾
        Vector3 pos = myTransform.position;
        pos.y += 0.036f;    // y���W��0.01���Z
        if(tama>=2)
        {
            pos.y -= 0.024f;
        }
        myTransform.position = pos;  // ���W��ݒ�
    }

// �N���b�N���ꂽ�Ƃ��ɌĂяo����郁�\�b�h
public void OnPointerClick(PointerEventData eventData)
    {
        TinyAudio.PlaySE(TinyAudio.SE.Click);
        tama += 1;
            Transform myTransform = this.transform;
            //print($"�I�u�W�F�N�g {name} ���N���b�N���ꂽ��I");
            Vector3 pos = myTransform.position;
            //pos.x += 0.01f;    // x���W��0.01���Z
            pos.y += 2.00f;    // y���W��0.01���Z
                               //pos.z += 0.01f;    // z���W��0.01���Z
            myTransform.position = pos;
    }
}

