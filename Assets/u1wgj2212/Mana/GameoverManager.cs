using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverManager : MonoBehaviour
{
    bool isShowRanking = false;

    int ss = GameManager.score;

    void Update()
    {
        //var rank = SceneManager.GetSceneByName("Ranking");
        //if (rank.IsValid()) return;
        

        if (isShowRanking)
        {
            var rank = SceneManager.GetSceneByName("Ranking");
            if ((rank == null) || !rank.IsValid())
            {
                isShowRanking = true;
            }
            return;
        }

        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(ss);
        isShowRanking = true;
    }
}