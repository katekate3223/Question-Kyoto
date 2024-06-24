using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger5T : MonoBehaviour
{
    private GameObject scoreManagerObject;
    private ScoreManagerTest scoreManagerTest;
    private Text scoreText;

    void Start()
    {
        scoreManagerObject = GameObject.Find("ScoreManager");
        scoreManagerTest = scoreManagerObject.GetComponent<ScoreManagerTest>();
        scoreText = GameObject.Find("questionCounterText").GetComponent<Text>();
        scoreManagerTest.scoreText = scoreText;
        scoreManagerTest.UpdateScoreText();
    }


    public void ChangeScene()
    {
        scoreManagerTest.IncrementScore();
        SceneManager.LoadScene("5T"); // シーンをロードする
    }

    /*
    public void IncrementScore()
    {
        correctAnswers++; // 正答数を増やす
        UpdateScoreText(); // UIテキストを更新する
    }

    // UIテキストを更新するメソッド
    private void UpdateScoreText()
    {
        // シーン内のテキストオブジェクトからテキストコンポーネントを取得し、正答数を表示する
        GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>().text = "正答数: " + correctAnswers.ToString();
    }
    */
}
