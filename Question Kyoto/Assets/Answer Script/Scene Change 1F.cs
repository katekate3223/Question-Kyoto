using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1F : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("1F"); // ランダムなシーンをロードする
    }
}