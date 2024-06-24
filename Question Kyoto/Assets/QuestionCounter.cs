using UnityEngine;
using UnityEngine.UI;

public class QuestionCounter : MonoBehaviour
{
    public Text questionCounterText;
    private int totalQuestions =11; // ����萔
    private int currentQuestion =1; // ���݂̖��ԍ�

    void Start()
    {
        // �����̖��ԍ��Ǝc��̖�萔��\������
        //UpdateQuestionCounter();
    }

    // ���ԍ��𑝂₵�ĕ\�����X�V����
    public void NextQuestion()
    {
        currentQuestion++;
        UpdateQuestionCounter();
    }

    // �c��̖�萔���v�Z���ĕ\�����X�V����
    private void UpdateQuestionCounter()
    {
        int remainingQuestions = totalQuestions - currentQuestion + 1;
        questionCounterText.text = "Question: " + currentQuestion + " / " + totalQuestions + "\nRemaining: " + remainingQuestions;
    }
}