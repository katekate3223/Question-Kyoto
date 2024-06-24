using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject textGameObject;
    public Button button;

    // isActive変数をメンバ変数として定義
    private bool isActive = false;

    private void Start()
    {
        // ボタンのクリックイベントにリスナーを追加
        button.onClick.AddListener(ToggleTextGameObject);
    }

    // ボタンがクリックされたときに呼ばれる関数
    private void ToggleTextGameObject()
    {
        // isActiveの値を反転させる
        isActive = !isActive;
        // textGameObjectのアクティブ状態をisActiveに合わせて切り替える
        textGameObject.SetActive(isActive);
        
        // ボタンを非アクティブにする
        button.gameObject.SetActive(false);
    }
}
