using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger7T : MonoBehaviour
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
         scoreManagerTest.correctAnswerArray[6] = true;
        scoreManagerTest.IncrementScore();
        SceneManager.LoadScene("7T"); // �V�[�������[�h����
    }

    /*
    public void IncrementScore()
    {
        correctAnswers++; // �������𑝂₷
        UpdateScoreText(); // UI�e�L�X�g���X�V����
    }

    // UI�e�L�X�g���X�V���郁�\�b�h
    private void UpdateScoreText()
    {
        // �V�[�����̃e�L�X�g�I�u�W�F�N�g����e�L�X�g�R���|�[�l���g���擾���A��������\������
        GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>().text = "������: " + correctAnswers.ToString();
    }
    */
}
