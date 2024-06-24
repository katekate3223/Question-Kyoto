using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeSceneRandom()
    {
        int randomSceneIndex = Random.Range(1,4); // 1から3までのランダムな値を生成する
        string sceneName = "Scene" + randomSceneIndex; // シーン名を生成する
        SceneManager.LoadScene(sceneName); // ランダムなシーンをロードする
    }
}