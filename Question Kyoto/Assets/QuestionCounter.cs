using UnityEngine;
using UnityEngine.UI;

public class QuestionCounter : MonoBehaviour
{
    public Text questionCounterText;
    private int totalQuestions =11; // 総問題数
    private int currentQuestion =1; // 現在の問題番号

    void Start()
    {
        // 初期の問題番号と残りの問題数を表示する
        //UpdateQuestionCounter();
    }

    // 問題番号を増やして表示を更新する
    public void NextQuestion()
    {
        currentQuestion++;
        UpdateQuestionCounter();
    }

    // 残りの問題数を計算して表示を更新する
    private void UpdateQuestionCounter()
    {
        int remainingQuestions = totalQuestions - currentQuestion + 1;
        questionCounterText.text = "Question: " + currentQuestion + " / " + totalQuestions + "\nRemaining: " + remainingQuestions;
    }
}