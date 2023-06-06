using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour
{
    int a = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (a == 0)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
                a = a + 1;
                //Time.timeScale = 0;

            }
        }
    }

}
