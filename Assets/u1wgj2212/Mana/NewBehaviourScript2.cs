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
                // transform���擾
                Transform myTransform = this.transform;

                // ���W���擾
                Vector3 pos = myTransform.position;
                pos.x = 10000.0f;    // y���W��0.01���Z

                myTransform.position = pos;  // ���W��ݒ�
            //Time.timeScale = 0;
        }
    }

}
