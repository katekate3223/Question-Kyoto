using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger4F : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("4F"); // ランダムなシーンをロードする
    }
}