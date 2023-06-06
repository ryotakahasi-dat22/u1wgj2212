using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {

        // transform���擾
        Transform myTransform = this.transform;

        // ���W���擾
        Vector3 pos = myTransform.position;
        pos.y += 0.048f;    // y���W��0.01���Z

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

        myTransform.position = pos;  // ���W��ݒ�
    }
}