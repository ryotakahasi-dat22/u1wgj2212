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
                // transform‚ğæ“¾
                Transform myTransform = this.transform;

                // À•W‚ğæ“¾
                Vector3 pos = myTransform.position;
                pos.x = 10000.0f;    // yÀ•W‚Ö0.01‰ÁZ

                myTransform.position = pos;  // À•W‚ğİ’è
            //Time.timeScale = 0;
        }
    }

}
