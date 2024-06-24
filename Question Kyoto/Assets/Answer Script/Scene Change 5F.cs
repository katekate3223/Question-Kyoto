using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger5F : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("5F"); // ランダムなシーンをロードする
    }
}