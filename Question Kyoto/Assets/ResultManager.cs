using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
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


        // ³‰ğ‚É‰‚¶‚Ä‰æ‘œ‚ÌON/OFF‚ğŒˆ‚ß‚é
        for (int i = 0; i < scoreManagerTest.correctAnswerArray.Length; i++)
        {
            answerImages[i].SetActive(scoreManagerTest.correctAnswerArray[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
