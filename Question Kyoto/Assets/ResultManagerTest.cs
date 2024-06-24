using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManagerTest : MonoBehaviour
{
    private GameObject scoreManagerObject;
    private ScoreManagerTest scoreManagerTest;
    private Text scoreText;
    public GameObject[] answerImages;

    // Start is called before the first frame update
    void Start()
    {
        scoreManagerObject = GameObject.Find("ScoreManager");
        scoreManagerTest = scoreManagerObject.GetComponent<ScoreManagerTest>();
        scoreText = GameObject.Find("questionCounterText").GetComponent<Text>();
        scoreManagerTest.scoreText = scoreText;
        scoreManagerTest.UpdateScoreText();

        // 正解に応じて画像のON/OFFを決める
        for (int i = 0; i < scoreManagerTest.correctAnswerArray.Length; i++)
        {
            if (scoreManagerTest.correctAnswerArray[i])
            {
                answerImages[i].SetActive(true); // 正解した場合、画像を表示
            }
            else
            {
                answerImages[i].SetActive(false); // 不正解の場合は非表示にする
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}