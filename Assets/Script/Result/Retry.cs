using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultUI : MonoBehaviour
{
    [SerializeField] private Button retryButton;
   
    [SerializeField] private Text resultText;

    void Start()
    {
       

        // ボタンに処理を登録
        retryButton.onClick.AddListener(OnRetry);
       
    }

    void OnRetry()
    {
        SceneManager.LoadScene("GameScene");
    }

   
}
