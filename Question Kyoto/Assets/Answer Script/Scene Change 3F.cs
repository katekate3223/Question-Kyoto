using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger3F : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("3F"); // ランダムなシーンをロードする
    }
}