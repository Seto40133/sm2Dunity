using UnityEngine;
using UnityEngine.SceneManagement; 

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            Debug.Log("ゴール！");

            SceneManager.LoadScene("ResultScene");

        }
    }
}
