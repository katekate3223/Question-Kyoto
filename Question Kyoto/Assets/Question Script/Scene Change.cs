using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeSceneRandom()
    {
        int randomSceneIndex = Random.Range(1,4); // 1����3�܂ł̃����_���Ȓl�𐶐�����
        string sceneName = "Scene" + randomSceneIndex; // �V�[�����𐶐�����
        SceneManager.LoadScene(sceneName); // �����_���ȃV�[�������[�h����
    }
}