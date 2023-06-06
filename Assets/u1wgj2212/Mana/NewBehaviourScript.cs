using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {

        // transform‚ğæ“¾
        Transform myTransform = this.transform;

        // À•W‚ğæ“¾
        Vector3 pos = myTransform.position;
        pos.y += 0.048f;    // yÀ•W‚Ö0.01‰ÁZ

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

        myTransform.position = pos;  // À•W‚ğİ’è
    }
}