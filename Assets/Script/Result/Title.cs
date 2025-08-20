using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    
    [SerializeField] private Button titleButton;
    [SerializeField] private Text resultText;

    void Start()
    {
        // スコアやクリアタイムを表示（GameManagerを使っている前提）
       

        // ボタンに処理を登録
       
        titleButton.onClick.AddListener(OnTitle);
    }

    

    void OnTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
