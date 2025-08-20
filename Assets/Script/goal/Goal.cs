using UnityEngine;
using UnityEngine.SceneManagement; 

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            Debug.Log("ゴール！");

            // 例：リザルト画面へ遷移
            SceneManager.LoadScene("ResultScene");

            // もし次のステージに進めたいなら
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
