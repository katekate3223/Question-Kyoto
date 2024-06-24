using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerTest : MonoBehaviour
{
    // 正答数を保持する変数
    private int correctAnswers = 0;
    // 問題数を保持する変数
    private int totalQuestions = 0;

    // UIテキスト要素を参照する変数
    public Text scoreText;

    // どの区の問題を正解したか
    public bool[] correctAnswerArray;

    // 初期化
    private void Start()
    {
        // 問題数を設定して表示
        totalQuestions = GetTotalQuestions(); // 問題数を取得する関数を呼び出す
        //UpdateScoreText();

        correctAnswerArray = new bool[this.GetTotalQuestions()];
        for (int i = 0; i < correctAnswerArray.Length; i++)
        {
            correctAnswerArray[i] = false;
        }
    }

    // 問題数を取得する関数（仮の関数）
    private int GetTotalQuestions()
    {
        // 問題数を仮で10としますが、実際には適切な方法で取得してください
        return 11;
    }

    // 正答数を増やす関数
    public void IncrementScore()
    {
        correctAnswers++;
        // 正答数が更新されたらUIテキストを更新
        UpdateScoreText();
    }

    // UIテキストを更新する関数
    public void UpdateScoreText()
    {
        scoreText.text = "正答数: " + correctAnswers.ToString() + " / " + totalQuestions.ToString();
    }
}