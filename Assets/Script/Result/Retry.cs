using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultUI : MonoBehaviour
{
    [SerializeField] private Button retryButton;
   
    [SerializeField] private Text resultText;

    void Start()
    {
       
        retryButton.onClick.AddListener(OnRetry);
       
    }

    void OnRetry()
    {
        SceneManager.LoadScene("GameScene");
    }

   
}
