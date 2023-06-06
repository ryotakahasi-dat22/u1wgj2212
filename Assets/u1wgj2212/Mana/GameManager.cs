#define DEBUG_KEY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField]
    TextMeshProUGUI scoreText = default;

    static int ScoreMax => 99999999;

    public static int score;
    //static int score;
    static float time;
    static float StartTime => 10;
    static bool clear;
    static bool gameover;


    // Start is called before the first frame update

    void Awake()
    {
        Instance = this;
        //ClearScore();
        //Item.ClearCount();
        time = StartTime;
        clear = false;
        gameover = false;
    }

    void Start()
    {
        //TinyAudio.PlaySE(TinyAudio.SE.Start);
    }


    // Update is called once per frame
    void Update()
    {
        AddPoint(1);
        if(score>=1000)
        {
            AddPoint(10);
        }
        if (score >= 10000)
        {
            AddPoint(100);
        }
        if (score >= 500000)
        {
            AddPoint(1000);
        }
#if DEBUG_KEY
        if (Input.GetKeyDown(KeyCode.O))
        {
            ToGameover();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ToClear();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            AddPoint(123);
        }
#endif

    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = $"{score:00000000}km";
        }
    }

    public static void AddPoint(int add)
    {
        score += add;

        //ãŒÀƒ`ƒFƒbƒN‚»‚Ì‚PŽè‘±‚«Œ^‚Ì“TŒ^
        /*
         if(score > ScoreMax)
        {
             score = ScoreMax;
        }
         */

        //ãŒÀƒ`ƒFƒbƒN‚»‚Ì‚Q@Žè‘±‚«Œ^‚ÌÈ—ªŒ`
        //score =score > ScoreMax ? ScoreMax : score;

        //ãŒÀƒ`ƒFƒbƒN‚»‚Ì‚RŠÖ”Œ^‚Å‹ß‘ã“I
        score = Mathf.Min(score + add, ScoreMax);

        if (score > ScoreMax)
        {
            score = ScoreMax;
        }
        if (Instance != null)
        {
            Instance.UpdateScoreText();
        }
    }

    /*public static void ClearScore()
    {
        score = 0;
        if (Instance != null)
        {
            Instance.UpdateScoreText();
        }
    }*/

    public static void ToClear()
    {
        if (clear || gameover) return;

        clear = true;
        // TODO CheckHighScore();
        SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
        //Time.timeScale = 0;
    }

    public static void ToGameover()
    {
        if (clear || gameover) return;

        gameover = true;
        // TODO CheckHighScore();
        SceneManager.LoadScene("Gameover", LoadSceneMode.Additive);
        //Time.timeScale = 0;
    }

}
