using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger10F : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("10F"); // ランダムなシーンをロードする
    }
}