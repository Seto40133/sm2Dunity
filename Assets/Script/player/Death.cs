using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDeath : MonoBehaviour
{
    public float deathY = -10f; 

    void Update()
    {
        if (transform.position.y < deathY)
        {
            Debug.Log("落下！ゲームオーバー");
            SceneManager.LoadScene("ResultScene"); 
        }
    }
}
