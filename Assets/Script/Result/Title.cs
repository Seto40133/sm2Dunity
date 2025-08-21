using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    
    [SerializeField] private Button titleButton;
    [SerializeField] private Text resultText;

    void Start()
    {
       
        titleButton.onClick.AddListener(OnTitle);
    }

    

    void OnTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
