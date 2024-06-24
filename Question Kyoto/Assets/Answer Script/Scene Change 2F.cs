using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2F : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("2F"); // ランダムなシーンをロードする
    }
}