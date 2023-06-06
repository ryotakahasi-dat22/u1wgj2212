using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour
{
    [Tooltip("Game"), SerializeField]
    string nextScene = default;
    bool sceneChanged;

    public void ChangeScene()
    {
        if (sceneChanged) return;

        sceneChanged = true;
        SceneManager.LoadScene(nextScene);
    }

}
