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

        // �����ɉ����ĉ摜��ON/OFF�����߂�
        for (int i = 0; i < scoreManagerTest.correctAnswerArray.Length; i++)
        {
            if (scoreManagerTest.correctAnswerArray[i])
            {
                answerImages[i].SetActive(true); // ���������ꍇ�A�摜��\��
            }
            else
            {
                answerImages[i].SetActive(false); // �s�����̏ꍇ�͔�\���ɂ���
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}