using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger5 : MonoBehaviour
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

    public void ChangeSceneRandom()
    {
        int randomSceneIndex = Random.Range(14, 16); // 4から6までのランダムな値を生成する
        string sceneName = "Scene" + randomSceneIndex; // シーン名を生成する
        SceneManager.LoadScene(sceneName); // ランダムなシーンをロードする
    }
}